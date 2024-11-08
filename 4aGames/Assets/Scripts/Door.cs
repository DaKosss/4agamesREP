using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public GameObject door_closed, door_opened, intText, lockedText;
    // public AudioSourse open, close;
    public bool opened, locked;
    public static bool keyfound;
    void Start(){
        keyfound = false;
    }
    void OnTriggerStay(Collider other)
 {
    if(other.CompareTag("MainCamera")) {
        if(locked == false){
            if(opened == false) {
            intText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E)) {
                door_closed.SetActive(false);
                door_opened.SetActive(true);
                intText.SetActive(false);
                //Open.Play();
                StartCoroutine(repeat());
                opened = true; }
            }
        }
    }
    if(locked == true){
        lockedText.SetActive(true);
    }
 }   
 void OnTriggerExit(Collider other) {
    if(other.CompareTag("MainCamera")) {
        intText.SetActive(false);
        lockedText.SetActive(false);
    }
 }
 IEnumerator repeat() {
    yield return new WaitForSeconds(1.0f);
    opened = false;
    door_closed.SetActive(true);
    door_opened.SetActive(false);
    //Close.Play();
 }
 void Update() {
    if(keyfound == true) {
        locked = false;
    }
 }
}
