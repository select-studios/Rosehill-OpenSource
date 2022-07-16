using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrabBuildString : MonoBehaviour
{
    public TMP_Text TextDisplay;

    // Start is called before the first frame update
    void Start()
    {
        TextDisplay.text = BuildInfo.BuildStringPublic.text;
    }
}
