using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelScript : MonoBehaviour
{
    public GameObject Shovel, intText;
    public static bool lopatafound;
    void Start()
    {
        lopatafound = false;
    }
 void OnTriggerStay(Collider other)
 {
    if(lopatafound == false){
        intText.SetActive(false);
    }
    else{
    if(other.CompareTag("MainCamera")) {
            intText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E)) {
                Shovel.SetActive(false);
                intText.SetActive(false);
                sandScript.sandfound = true;
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
