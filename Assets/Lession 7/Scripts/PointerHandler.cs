using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerHandler : MonoBehaviour, IPointerEnterHandler, IPointerDownHandler, IPointerExitHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Cursor Entering " + name + " GameObject");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Cursor Down " + name + " GameObject");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Cursor Exit " + name + " GameObject");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Cursor Up " + name + " GameObject");
    }
}
