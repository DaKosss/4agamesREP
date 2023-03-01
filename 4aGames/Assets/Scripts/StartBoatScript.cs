using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBoatScript : MonoBehaviour
{
    public GameObject inticon, boat, boattext;

    void OnTriggerStay(Collider other) {
        if(other.CompareTag("MainCamera")) {
            inticon.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E)) {
                boattext.SetActive(true);
            }
        }
    }
    void onTriggerExit(Collider other) {
        if(other.CompareTag("MainCamera")) {
            inticon.SetActive(false);
            boattext.SetActive(false);
        }
    }
}
