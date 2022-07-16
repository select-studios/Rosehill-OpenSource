using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteract : MonoBehaviour
{
    public GameObject DoorOpen;
    public GameObject DoorClosed;
    public bool _InRange = false;
    public bool _Open = true;

    private void Start()
    {
        if (_Open == true)
        {
            DoorOpen.SetActive(true);
        }
        else
        {
            DoorOpen.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(_InRange == true && _Open == true)
            {
                close();
            }else if(_InRange == true && _Open == false)
            {
                open();
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        _InRange = true;
    }

    public void OnTriggerExit(Collider other)
    {
        _InRange = false;
    }

    public void close()
    {
        DoorClosed.SetActive(true);
        DoorOpen.SetActive(false);
        _Open = false;
    }

    public void open()
    {
        DoorClosed.SetActive(false);
        DoorOpen.SetActive(true);
        _Open = true;
    }

}
