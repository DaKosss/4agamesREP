using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videoscremer : MonoBehaviour
{
    public int time;
    public GameObject Collider;
    public GameObject vidoe;
    public bool GameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(GameOver == true)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                    }

            }
        

    }

    private void OnTriggerEnter(Collider Collider)
    {
        if (Collider.gameObject.tag == "Screamervideo")
        {

            vidoe.SetActive(true);
            GameOver = true;
            Destroy(gameObject);
            

        }
        else
        {
            vidoe.SetActive(false);
        }



    }
}
