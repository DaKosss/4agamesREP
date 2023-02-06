using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    Light Fl;
    public KeyCode flkey;
    public AudioClip soundfl;
    // Start is called before the first frame update
    void Start()
    { 
        Fl= GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(flkey))
        {
            Fl.enabled = !Fl.enabled;
            GetComponent<AudioSource>().PlayOneShot(soundfl);
        }
    }
}
