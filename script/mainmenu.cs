using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    public int gamestartscene;
    string file = Application.dataPath + "/levelat.txt";
    
    public void startgame()
    {
        SceneManager.LoadScene(gamestartscene);
        Debug.Log("h");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!File.Exists(file))
            File.Create(file);

       
    }
    public void Quitgame()
    {
        Application.Quit();
    }
}
