using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlenderSound : MonoBehaviour
{
    public AudioSource screamerSource;
    public AudioClip screamerSound;
    public GameObject Collider;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider Collider)
    {
        if (Collider.gameObject.tag == "ScreamerTrigger")
        {
            screamerSource.PlayOneShot(screamerSound);

       
        }


        
    }

    private void OnTriggerExit(Collider Collider)
    {
        if (Collider.gameObject.tag == "ScreamerTrigger")
        {
            if (screamerSource.isPlaying)
            {
               
                screamerSource.Stop();
               

            }
        }
    }
}
