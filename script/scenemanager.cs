using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class scenemanager : MonoBehaviour
{
    //public goal scenemanager_goal;

    public void LoadScene(string sceneName)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);
    }

   /* public void restartlevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(goal.);
    }
    */
}
