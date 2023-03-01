using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class videoscremer : MonoBehaviour
{
    VideoPlayer player;

    public int time;
    public GameObject Collider;
    public GameObject vidoe;
    public bool GameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        player = vidoe.GetComponent<VideoPlayer>();
        player.Prepare();
        player.loopPointReached += _videoPlayer_loopPointReached;
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

    private void _videoPlayer_loopPointReached(VideoPlayer source)
    {
        SceneManager.LoadScene(3);
    }
}
