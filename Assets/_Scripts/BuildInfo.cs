using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildInfo : MonoBehaviour
{
    public int Major, Minor, Patch;
    public TMP_Text BuildString;
    public bool _isDevelopement;
    public bool _OpenBeta;
    public bool _Release;

    [Space]
    [Header("Public")]
    public static TMP_Text BuildStringPublic;
    public static bool _Developer;

    // Start is called before the first frame update
    void Start()
    {
        //Set Priority
        if(_isDevelopement && _Release == true)
        {
            _isDevelopement = false;
            _Release = true;
        }

        if (_OpenBeta && _Release == true)
        {
            _OpenBeta = false;
            _Release = true;
        }

        if (_OpenBeta && _isDevelopement== true)
        {
            _OpenBeta = false;
            _isDevelopement = false;
            _Release = true;
        }


        if (_isDevelopement == true)
        {
            BuildString.text = Major + "." + Minor + "." + Patch + " [Development]";
        }

        if (_OpenBeta == true)
        {
            BuildString.text = Major + "." + Minor + "." + Patch + " [OpenBeta]";
        }

        if (_Release == true)
        {
            BuildString.text = Major + "." + Minor + "." + Patch;
        }

        BuildStringPublic.text = BuildString.text;
        _Developer = _isDevelopement;

    }
}
