using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class inventoryMenu : MonoBehaviour
{
    public AudioListener audioListener;
    public GameObject CanvasMenu;
    public GameObject CanvasUI;
    public GameObject lockUI;
    public GameObject helpTable;
    public static bool GameIsPaused = false;
    // Start is called before the first frame update
    public void ExitMainMenuGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void ContinueGame()
    {
        CanvasMenu.SetActive(false);
        CanvasUI.SetActive(true);
        Time.timeScale = 1.0f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void PauseGame()
    {
        CanvasMenu.SetActive(true);
        CanvasUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            helpTable.SetActive(false);

            if(!lockUI.activeSelf)
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(!lockUI.activeSelf)
            {
                if (GameIsPaused)
                {
                    ContinueGame();
                }
            }
        }

    }
}
