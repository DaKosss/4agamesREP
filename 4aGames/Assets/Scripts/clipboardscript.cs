using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clipboardscript : MonoBehaviour
{

    public GameObject ClipBoard, intText;
    void Start()
    {

    }
 void OnTriggerStay(Collider other)
 {
    if(other.CompareTag("MainCamera")) {
            intText.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E)) {
                ClipBoard.SetActive(false);
                intText.SetActive(false);
                ShovelScript.lopatafound = true; }
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
