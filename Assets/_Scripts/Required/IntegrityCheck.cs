using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class IntegrityCheck : MonoBehaviour
{
    protected string PiracyDetected = "PirateDetected";

    // Start is called before the first frame update
    void Start()
    {
        if (Application.genuineCheckAvailable)
        {
            if (Application.genuine)
            {
                Debug.Log("Application passed Integrity Checks");
            }
            else
            {
                SceneManager.LoadScene(PiracyDetected);
            }
        }
    }
}
