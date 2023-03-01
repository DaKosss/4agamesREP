using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIlock : MonoBehaviour
{
    public AudioListener audioListener;
    public GameObject CanvasMenu;
    public GameObject CanvasUI;
    public GameObject menuButtons;
    public GameObject intText;
    public AudioSource lockSource;
    public AudioClip lockLockedClip;
    public AudioClip lockNumClip;
    public static bool GameIsPaused = false;

    public Text intText1;
    public Text intText3;
    public Text intText2;
    public Text intText4;

    // Start is called before the first frame update

    bool interactable = false;
    bool openedWindow = false;
    public static int num1 = 1, num2 = 1, num3 = 1, num4 = 1;
    

    public void ContinueGame()
    {
        openedWindow = false;
        CanvasMenu.SetActive(false);
        CanvasUI.SetActive(true);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void PauseGame()
    {
        openedWindow = true;
        CanvasMenu.SetActive(true);
        CanvasUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

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

    int numRepeat(int num)
    {
        if (num > 9) return 1;
        else
        if (num < 1) return 9;
        else return num;
    }

    public void num1Up()
    {
        num1++;
        num1 = numRepeat(num1);
        intText1.text = num1.ToString();
        lockSource.PlayOneShot(lockNumClip);

    }

    public void num1Down()
    {
        num1--;
        num1 = numRepeat(num1);
        intText1.text = num1.ToString();
        lockSource.PlayOneShot(lockNumClip);
    }

    public void num2Up()
    {
        num2++;
        num2 = numRepeat(num2);
        intText2.text = num2.ToString();
        lockSource.PlayOneShot(lockNumClip);
    }

    public void num2Down()
    {
        num2--;
        num2 = numRepeat(num2);
        intText2.text = num2.ToString();
        lockSource.PlayOneShot(lockNumClip);
    }

    public void num3Up()
    {
        num3++;
        num3 = numRepeat(num3);
        intText3.text = num3.ToString();
        lockSource.PlayOneShot(lockNumClip);
    }

    public void num3Down()
    {
        num3--;
        num3 = numRepeat(num3);
        intText3.text = num3.ToString();
        lockSource.PlayOneShot(lockNumClip);
    }

    public void num4Up()
    {
        num4++;
        num4 = numRepeat(num4);
        intText4.text = num4.ToString();
        lockSource.PlayOneShot(lockNumClip);
    }

    public void num4Down()
    {
        num4--;
        num4 = numRepeat(num4);
        intText4.text = num4.ToString();
        lockSource.PlayOneShot(lockNumClip);
    }

    public void back()
    {
        ContinueGame();
    }

    public void unlock()
    {
        if(num1 == 1 && num2 == 7 && num3 == 4 && num4 == 3)
            SceneManager.LoadScene(4);
        else
        {
            lockSource.PlayOneShot(lockLockedClip);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(interactable)
            {
                PauseGame();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(openedWindow)
            {
                if (GameIsPaused)
                {
                    ContinueGame();
                }
                else
                {
                    PauseGame();
                }
            } 
        }


    }
}
