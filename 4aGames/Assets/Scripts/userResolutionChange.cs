using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class userResolutionChange : MonoBehaviour
{

    public TMP_Dropdown DropDown;
    public Toggle toggleFullScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropD()
    {
        if(DropDown.value == 0)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        if (DropDown.value == 1)
        {
            Screen.SetResolution(1280, 720, true);
        }
        if (DropDown.value == 2)
        {
            Screen.SetResolution(1024, 576, true);
        }
    }

    public void setFullScreen()
    {
        

        if (toggleFullScreen.isOn) Screen.fullScreen = true;
        else Screen.fullScreen = false;
    }
}
