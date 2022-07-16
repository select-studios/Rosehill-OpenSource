using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseDoorOpen : MonoBehaviour
{
    public GameObject HorrorSeated;
    public GameObject HorrorStood;
    [Space]
    public GameObject DoorClose;
    public GameObject DoorOpen;

    public void OnTriggerEnter(Collider other)
    {
        if(Flashlight._FlashlightCollected == true)
        {
            HorrorSeated.SetActive(false);
            DoorClose.SetActive(false);
            //
            HorrorStood.SetActive(true);
            DoorOpen.SetActive(true);
        }
    }
}
