using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRecerbZone : MonoBehaviour
{
    public GameObject playerCollider;
    public GameObject reverbZone;
    public AudioLowPassFilter lowPassFilter; 

    public bool lowPass_ON;

    public bool lowPass_OFF;

    public float lowPass_speed = 100000f;

    private void OnTriggerEnter(Collider playerCollider)
    {
        if (playerCollider.gameObject.tag == "Player")
        {
            reverbZone.SetActive(true);

            lowPass_ON = true;
            lowPass_OFF = false;
        }
            
    }

    private void OnTriggerExit(Collider playerCollider)
    {
        if(playerCollider.gameObject.tag == "Player")
        {
            reverbZone.SetActive(false);

            lowPass_ON = false;
            lowPass_OFF = true;
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        lowPass_ON = false;
    }

    // Update is called once per frames
    void Update()
    {
        if (lowPass_ON)
        {
            lowPassFilter.cutoffFrequency = Mathf.MoveTowards(lowPassFilter.cutoffFrequency, 3000, lowPass_speed);
            if (lowPassFilter.cutoffFrequency == 3000) lowPass_ON = false;
        }
        else if (lowPass_OFF)
        {
            lowPassFilter.cutoffFrequency = Mathf.MoveTowards(lowPassFilter.cutoffFrequency, 22000, lowPass_speed);
            if (lowPassFilter.cutoffFrequency == 22000) lowPass_OFF = false;
        }
    }
}
