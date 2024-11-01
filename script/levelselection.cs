using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro.SpriteAssetUtilities;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class levelselection : MonoBehaviour
{
    public Button[] lvButtons;
    public int levelat;

  


    

    // Start is called before the first frame update
    void Start()
    {
        //int levelAt = PlayerPrefs.GetInt("levelAt", 3);

        
        
       
    }
    private void Update()
    {
        string file = Application.dataPath + "/levelat.txt";
        string str = File.ReadAllText(file);
        if (File.Exists(file))
        {
            
                    Console.WriteLine(str);
                    levelat = Int16.Parse(str);
            
            // Read all the content in one string 
            // and display the string 
            
        }
        
        
        /*
        for(i = 0; i < lvButtons.Length; i++)
        {
            if(i>levelat) 
            {
                lvButtons[i].interactable = false;
            }
        }
        i=0;
        for (j = 0; j < lvButtons.Length; j++)
        {
            if (j < levelat)
            {
                lvButtons[j].interactable = true;
            }
        }
        j = 0;
        */

        // lvButtons[enable].interactable = true;
        // lvButtons[disable].interactable = false;
        /*
        for(enable=0;enable<levelat;enable++)
        {
            lvButtons[enable].interactable = true;
        }
        enable = 0;
        
        for (disable = levelat;disable<12; disable++)
        {
            lvButtons[disable].interactable = false;
            //Debug.Log(disable);
        }
        disable = 0;*/


            for (int i = levelat+1; i <= 10; i++)
            {
                lvButtons[i].interactable = false;
            }
            for (int i = 1; i <= levelat; i++)
            {
                lvButtons[i].interactable = true;
            }
      
        /*
        if (levelat == 4)
        {
            lvButtons[5].interactable = false;
            lvButtons[6].interactable = false;
            lvButtons[7].interactable = false;
            lvButtons[8].interactable = false;
            lvButtons[9].interactable = false;
            lvButtons[10].interactable = false;
            lvButtons[11].interactable = false;
            lvButtons[12].interactable = false;
        }
        if (levelat == 5)
        {
            lvButtons[6].interactable = false;
            lvButtons[7].interactable = false;
            lvButtons[8].interactable = false;
            lvButtons[9].interactable = false;
            lvButtons[10].interactable = false;
            lvButtons[11].interactable = false;
            lvButtons[12].interactable = false;
        }
        if (levelat == 6)
        {
            lvButtons[7].interactable = false;
            lvButtons[8].interactable = false;
            lvButtons[9].interactable = false;
            lvButtons[10].interactable = false;
            lvButtons[11].interactable = false;
            lvButtons[12].interactable = false;
        }
        if (levelat == 7)
        {
            lvButtons[8].interactable = false;
            lvButtons[9].interactable = false;
            lvButtons[10].interactable = false;
            lvButtons[11].interactable = false;
            lvButtons[12].interactable = false;
        }
        if (levelat == 8)
        {
            lvButtons[9].interactable = false;
            lvButtons[10].interactable = false;
            lvButtons[11].interactable = false;
            lvButtons[12].interactable = false;
        }
        if (levelat == 9)
        {
            lvButtons[10].interactable = false;
            lvButtons[11].interactable = false;
            lvButtons[12].interactable = false;
        }
        if (levelat==10)
        {
            lvButtons[11].interactable = false;
            lvButtons[12].interactable = false;
        }
        if (levelat == 11)
        {
            lvButtons[12].interactable = false;
        }*/
    }
}
