using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuState : MonoBehaviour
{
    public enum whatAction
    {
        ATTACK,
        DEFEND
    }
    public HeroStateMachine Hero;
    public whatAction curAction;
    public GameObject ActionPanel;
    public GameObject EnemySelectPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        ActionPanel.SetActive(false);
        EnemySelectPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectHero(HeroStateMachine h)
    {
        Hero = h;
    }
    public void selectAttack()
    {
        curAction = whatAction.ATTACK;
    }
    public void selectDefend()
    {
        curAction = whatAction.DEFEND;
    }
}
