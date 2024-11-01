using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;



public class goal : MonoBehaviour
{
    //public scenemanager scenemanager_goal;
    public int nextsceneload;
    string file = Application.dataPath + "/levelat.txt";
    public int levelat;
    public int thislevel;
    public TextMeshProUGUI level;
    

    // Start is called before the first frame update
    void Start()
    {
        nextsceneload = SceneManager.GetActiveScene().buildIndex + 1;
        string str = File.ReadAllText(file);
        Console.WriteLine(str);
        levelat = Int16.Parse(str);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            uplevel();
            
            //SceneManager.LoadScene("mainmenu");
            /*
            if(nextsceneload>PlayerPrefs.GetInt("levelat"))
            {
                PlayerPrefs.SetInt("levelat",nextsceneload);
            }*/
        }
    }
    public void Update()
    {
        level.text = "Level " + thislevel;
    }

    public void uplevel()
    {



        if (levelat <= thislevel)
        {
            levelat = thislevel + 1;
            TextWriter tw = new StreamWriter(file, false);
            tw.Write(string.Empty);
            tw.Write(levelat);
            tw.Close();
        }
    }

}
