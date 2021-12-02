using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    public int difficulty;
    public void SetDifficulty (int a)
    {
        difficulty = a;
        Debug.Log(difficulty);
    }
}
