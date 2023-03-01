using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sandScript : MonoBehaviour
{
   public GameObject Sand, intText;
    public static bool sandfound;
    void Start()
    {
        sandfound = false;
    }
 void OnTriggerStay(Collider other)
 {
    if(sandfound == false){
        intText.SetActive(false);
    }
    else{
    if(other.CompareTag("MainCamera")) {
            intText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E)) {
                Sand.SetActive(false);
                intText.SetActive(false);
                PanScript.panfound = true;
                 }
            }
        }
    }
 void OnTriggerExit(Collider other) {
    if(other.CompareTag("MainCamera")) {
        intText.SetActive(false);
    }
 }
    void Update()
    {

    }
}
