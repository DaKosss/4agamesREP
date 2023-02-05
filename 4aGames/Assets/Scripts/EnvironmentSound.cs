using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSound : MonoBehaviour
{
    public AudioSource environmentSoundSource;
    public AudioClip environmentSound;

    // Start is called before the first frame update
    void Start()
    {
        environmentSoundSource = GetComponent<AudioSource>();

        environmentSoundSource.PlayOneShot(environmentSound);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(AudioClip clip)
    {
        
    }
}
