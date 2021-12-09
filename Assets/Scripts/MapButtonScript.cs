using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MapButtonScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Metaforum;
    bool inContext;
    public GameObject myGO;

    public void MetaforumToggle ()
    {
        Debug.Log("Metaforum Toggle");
    }
 
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !inContext)
        {
            myGO.SetActive(false);
        }
    }
 
    public void OnPointerEnter(PointerEventData eventData)
    {
        inContext = true;
        Debug.Log("Entered");
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        inContext = false;
    }

}
