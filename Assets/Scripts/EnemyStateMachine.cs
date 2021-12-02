using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    private BattleStateMachine BSM;
    public BaseEnemy enemy;

    public enum TurnState
    {
        PROCESSING,
        CHOOSEACTION,
        WAITING,
        ACTION,
        DEAD
    }

    public TurnState currentState;

    // for health bar
    private float cur_cooldown=0f;
    private float max_cooldown=2f;

    //this gameObject
    private Vector3 startPosition;

    
    // Start is called before the first frame update
    void Start()
    {
        currentState = TurnState.PROCESSING;
        BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine> ();
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentState)
        {
            case(TurnState.PROCESSING):
                UpgradeProgressBar();
                break;
            case(TurnState.CHOOSEACTION):
                ChooseAction();
                currentState = TurnState.WAITING;
                break;
            case(TurnState.WAITING):

                break;
            case(TurnState.ACTION):

                break;
            case(TurnState.DEAD):

                break;     
        }
    }

    void UpgradeProgressBar()
    {
        cur_cooldown = cur_cooldown + Time.deltaTime;
        if(cur_cooldown >= max_cooldown)
        {
            currentState = TurnState.CHOOSEACTION;
        }
    }

    void ChooseAction()
    {
        HandleTurn myAttack = new HandleTurn ();
        myAttack.Attacker = enemy.name;
        myAttack.AttackersGameObject = this.gameObject;
        myAttack.AttackersTarget = BSM.HerosInBattle[Random.Range(0, BSM.HerosInBattle.Count)];
        BSM.CollectActions(myAttack);
    }
}
