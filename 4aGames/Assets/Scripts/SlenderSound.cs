using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlenderSound : MonoBehaviour
{
    public AudioSource screamerSource;
    public AudioClip screamerSound;
    public GameObject Collider;
    public int timeStop;
    public GameObject vidoe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vidoe.SetActive(false);
    }

    private void OnTriggerEnter(Collider Collider)
    {
        if (Collider.gameObject.tag == "ScreamerTrigger")
        {
            screamerSource.PlayOneShot(screamerSound);
            vidoe.SetActive(true);
            Destroy(vidoe, timeStop);
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
