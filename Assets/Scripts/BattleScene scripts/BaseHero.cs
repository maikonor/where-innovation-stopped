using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseHero
{
    public string name;
    
    // players base and current health stats.
    public float baseHP;
    public float curHP;

    // players base and current Mana stats.
    public float baseMana;
    public float curMana;

    // players extra stats.
    public int stamina;
    public int speed;
    public int Attack;
    public int Defense;
    

}
