using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcontrolui : MonoBehaviour
{
    public GameObject soundcontrolUI;

    public void opencontrol()
    {
        soundcontrolUI.SetActive(true);
    }
    public void closecontrol()
    {
        soundcontrolUI.SetActive(false);
    }

}

