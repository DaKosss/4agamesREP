using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoscremer : MonoBehaviour
{
    public int time;
    public GameObject Collider;
    public GameObject vidoe;
    
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
        if (Collider.gameObject.tag == "Screamervideo")
        {
           
            vidoe.SetActive(true);
          Destroy(gameObject);
        }
        else
        {
            vidoe.SetActive(false);
        }



    }
}
