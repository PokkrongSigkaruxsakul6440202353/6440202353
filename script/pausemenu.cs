using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool gameispause = false;

    public GameObject pausemenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameispause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (pausemenuUI.activeSelf == true)
        {
            Time.timeScale = 0f;
        }
    }

    public void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameispause = false;
        SendMessage("PResume");
    }

    public void Pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameispause = true;
        SendMessage("PPause");
    }

    public void loadmenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("mainmenu");
    }

    public void Quitgame() 
    {
        Application.Quit();
    }
}
