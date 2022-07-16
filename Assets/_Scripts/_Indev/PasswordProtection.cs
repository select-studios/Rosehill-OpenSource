using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class PasswordProtection : MonoBehaviour
{
    public static bool _Unlocked = false;
    public string MainMenu;
    public string Key;
    [Space]
    public TMP_InputField KeyInput;
    [Space]
    public int Attempts;
    public int MaxAttempts = 3;
    [Space]
    public string PirateScene;

    private void Start()
    {
        Attempts = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            check();
        }
    }

    public void check()
    {
        if(KeyInput.text == Key)
        {
            Unlocked();
        }
        else
        {
            Incorrect();
        }
    }

    public void Incorrect()
    {
        Attempts++;


        if (Attempts >= MaxAttempts)
        {
            SceneManager.LoadScene(PirateScene);
        }
    }

    public void Unlocked()
    {
        _Unlocked = true;
        SceneManager.LoadScene(MainMenu);   
    }
}
