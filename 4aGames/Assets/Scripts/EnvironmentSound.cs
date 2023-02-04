using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSound : MonoBehaviour
{
    //public AudioSource environmentSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(AudioClip clip)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
