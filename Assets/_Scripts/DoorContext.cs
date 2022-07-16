using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorContext : MonoBehaviour
{
    public TMP_Text context;
    public GameObject contextObject;
    public string text;

    private void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        contextObject.SetActive(true);
        if (Flashlight._FlashlightCollected == true)
        {
            context.text = text;
        }

        if(Notes._Note == false)
        {
            context.text = "I sware i saw something on the TV?";
        }

        if(Flashlight._FlashlightCollected == false)
        {
            context.text = "I need my flashlight first";
        }

    }

    public void OnTriggerExit(Collider other)
    {
        contextObject.SetActive(false);
    }

}
