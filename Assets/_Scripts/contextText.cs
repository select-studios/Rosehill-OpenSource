using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class contextText : MonoBehaviour
{
    public TMP_Text context;
    public GameObject contextObject;
    public string text;

    public void OnTriggerEnter(Collider other)
    {
        contextObject.SetActive(true);
        context.text = text;
    }

    public void OnTriggerExit(Collider other)
    {
        contextObject.SetActive(false);
    }

}
