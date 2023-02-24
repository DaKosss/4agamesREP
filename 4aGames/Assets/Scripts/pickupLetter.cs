using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pickupLetter : MonoBehaviour
{
    public GameObject collectTextObj, intText;
    //public List<GameObject> collectLists = new List<GameObject>();
    //public AudioSource pickupSound, ambianceLayer1, ambianceLayer2, ambianceLayer3, ambianceLayer4, ambianceLayer5, ambianceLayer6, ambianceLayer7, ambianceLayer8;
    public AudioSource collectAudioSource;
    public AudioClip collectAudioClip;
    public bool interactable = false;
    public static int pagesCollected = 0;
    public Text collectText;
    public GameObject letterObj;


    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {

        if (interactable)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pagesCollected++;
                collectText.text = pagesCollected + "/8 pages";
                collectTextObj.SetActive(true);
                collectAudioSource.Play();
                collectAudioSource.PlayOneShot(collectAudioClip);
                letterObj.SetActive(false);

                //switch(pagesCollected)
                //{
                //    case 1:
                //        //ambianceLayer1.Play();
                //        collectAudioSource.PlayOneShot(collectAudioClip);
                //        collectLists[0].SetActive(false);
                //        break;
                //    case 2:
                //        //ambianceLayer2.Play();
                //        collectAudioSource.PlayOneShot(collectAudioClip);
                //        collectLists[1].SetActive(false);
                //        break;
                //    case 3:
                //        //ambianceLayer3.Play();
                //        collectAudioSource.PlayOneShot(collectAudioClip);
                //        collectLists[2].SetActive(false);
                //        break;
                //    case 4:
                //        //ambianceLayer4.Play();
                //        collectAudioSource.PlayOneShot(collectAudioClip);
                //        collectLists[3].SetActive(false);
                //        break;
                //    case 5:
                //        //ambianceLayer5.Play();
                //        collectAudioSource.PlayOneShot(collectAudioClip);
                //        collectLists[4].SetActive(false);
                //        break;
                //    case 6:
                //        //ambianceLayer6.Play();
                //        collectAudioSource.PlayOneShot(collectAudioClip);
                //        collectLists[5].SetActive(false);
                //        break;
                //    case 7:
                //        //ambianceLayer7.Play();
                //        collectAudioSource.PlayOneShot(collectAudioClip);
                //        collectLists[6].SetActive(false);
                //        break;
                //    case 8:
                //        //ambianceLayer8.Play();
                //        collectAudioSource.PlayOneShot(collectAudioClip);
                //        collectLists[7].SetActive(false);
                //        break;
                //}
                intText.SetActive(false);
                //this.gameObject.SetActive(false);
                interactable = false;
                if (pagesCollected == 8)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
              
            }
        }
    }
}