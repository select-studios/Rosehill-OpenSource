using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;
    public GameObject DoorTrigger;
    public static bool _FlashlightCollected;
    public bool _Range = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _Range == true)
        {
            flashlight.SetActive(false);
            DoorTrigger.SetActive(true);
            _FlashlightCollected = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        _Range = true;
    }

    public void OnTriggerExit(Collider other)
    {
        _Range = false;
    }

}
