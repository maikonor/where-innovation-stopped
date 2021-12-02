using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public GameObject panel;

    public void ChangePanelState(bool state){
        panel.SetActive(state);
    }
}
