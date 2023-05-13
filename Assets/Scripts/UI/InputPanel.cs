using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputPanel : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static InputPanel instance;
    private void Awake()
    {
        instance = this;
    }

    [System.NonSerialized] public bool pointerDown;
    
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        pointerDown = true;
        //Debug.Log("Bastı");
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        pointerDown = false;
        //Debug.Log("kalktı");

    }
}
