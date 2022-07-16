using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Notes : MonoBehaviour
{
    //attach to a trigger cube thing

    public GameObject Note;
    public GameObject UINote;
    public bool _Read = false;
    public bool _inrange = false;
    [Space]
    public GameObject Flashlight;
    public TMP_Text Objective;
    public static bool _Note = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _inrange == true)
        {
            if(_Read == false)
            {
                OpenNote();
            }
            else
            {
                CloseNote();
            }
        }
    }

    public void OpenNote()
    {
        UINote.SetActive(true);
        _Read = true;
        Time.timeScale = 0f;

        //Progress manager info
    }

    public void CloseNote()
    {
        UINote.SetActive(false);
        Note.SetActive(false);
        _Note = true;
        Time.timeScale = 1f;
        nextphase();
    }

    private void OnTriggerEnter(Collider other)
    {
        _inrange = true;
    }
    private void OnTriggerExit(Collider other)
    {
        _inrange = false;
    }

    public void nextphase()
    {
        Flashlight.SetActive(true);
        Objective.text = "I need to get my flashlight and go...";
    }


}
