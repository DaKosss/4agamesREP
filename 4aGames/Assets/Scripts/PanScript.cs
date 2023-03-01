using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanScript : MonoBehaviour
{
    public GameObject Pan, intText;
    public static bool panfound;
    void Start()
    {
        panfound = false;
    }
 void OnTriggerStay(Collider other)
 {
    if(panfound == false){
        intText.SetActive(false);
    }
    else{
    if(other.CompareTag("MainCamera")) {
            intText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E)) {
                Pan.SetActive(false);
                intText.SetActive(false);
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