using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numlock : MonoBehaviour
{
    public int Level;
    public bool interactable = false;
    // Start is called before the first frame update
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            interactable = false;
        }
    }
    void Update()
    {

        if (interactable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {


                Application.LoadLevel(Level);

                interactable = false;




            }
        }
    }
}
