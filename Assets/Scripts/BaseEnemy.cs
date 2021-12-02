using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy
{
    public string name;
    
    public enum Study
    {
        COMPU,
        ID,
        AUTOMOTIVE,
        CHEM,
        BMT,
        ELECTRICAL,
        PHYSICS,
        MECHANICAL,
        PSYCOLOGY
    }

    public enum Rarity
    {
        COMMON,
        UNCOMMON,
        RARE,
        EPIC
    }

    public Study EnemyType;
    public Rarity rarity;

    // enemy health stats.
    public float baseHP;
    public float curHP;

    // enemy Mana stats.
    public float baseMana;
    public float curMana;
    
    public float baseATK;
    public float curATK;
    public float baseDEF;
    public float curDEF;


}
