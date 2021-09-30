using UnityEngine;
using UnityEngine.EventSystems;

namespace Lession9
{
    public class PointerHandler : EventTrigger
    {
        public void OnMouseEnter()
        {
            Debug.Log("Mouse Enter");
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            Debug.Log("OnPointerEnter Enter");
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Debug.Log("OnPointerExit Enter");
        }
    }
}


