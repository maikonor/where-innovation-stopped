    using UnityEngine;
    using UnityEngine.EventSystems;
     
    public class CloseOnClickOff : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        bool inContext;
        GameObject myGO;
     
        private void Awake()
        {
            myGO = gameObject;
        }
     
        void Update()
        {
            if (Input.GetMouseButtonDown(0) && !inContext)
            {
                myGO.SetActive(inContext);
            }
        }
     
        public void OnPointerEnter(PointerEventData eventData)
        {
            inContext = true;
            
        }
     
        public void OnPointerExit(PointerEventData eventData)
        {
            inContext = false;
            Debug.Log("Out of Ui");
        }
    }

