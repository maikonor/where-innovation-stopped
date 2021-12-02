using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    public float difficulty;


    public void SetDifficulty (float a)
    {
        difficulty = a;
        Debug.Log(difficulty);
    }
}
