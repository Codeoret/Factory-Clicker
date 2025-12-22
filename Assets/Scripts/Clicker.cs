using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Clicker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        AddScore();
    }

}
