using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    
    public SpriteRenderer part;
    public Sprite[] options;
    public Slider slider;


    public void Swap(){

        part.sprite = options[(int)slider.value];
    }
}
