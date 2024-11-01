using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;
using System.IO;
using System.Runtime.CompilerServices;

public class player : MonoBehaviour
{
    public bool gameispause = false;
    public float speed;
    public int died = 0;
    public TextMeshProUGUI skeletonkeytext;
    public TextMeshProUGUI bonekeytext;
    public TextMeshProUGUI diamondkeytext;
    public TextMeshProUGUI starkeytext;
    public TextMeshProUGUI diedcount;
    public GameObject door;
    //public TextMeshProUGUI youwin;
    public GameObject winUI;
    public GameObject diedUI;
    public GameObject pausemenuUI;
    
    public int skeletonkeyhave = 0;
    public int skeletonkeyamount;

    public int bonekeyhave = 0;
    public int bonekeyamount;

    public int diamondkeyhave = 0;
    public int diamondkeyamount;

    public int starkeyhave = 0;
    public int starkeyamount;


    public soundeffectplayer player_soundeffectplayer;
    public valuestroage player_valuestroage;

    string file = Application.dataPath + "/deathcount.txt";

    private GameObject currentTeleporter;
    

    // Start is called before the first frame update

    public void PResume()
    {

        Time.timeScale = 1f;
        gameispause = false;

    }

    public void PPause()
    {

        Time.timeScale = 0f;
        gameispause = true;

    }

    

    // Update is called once per frame
    void Update()
    {
        
       
        //move

        

        if ( (gameispause == false) && (pausemenuUI.activeSelf == false) && (winUI.activeSelf == false) )
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, -speed, 0, 0);
            }
        }
        //door
        skeletonkeytext.text = skeletonkeyhave + "/" + skeletonkeyamount;
        bonekeytext.text = bonekeyhave + "/" + bonekeyamount;
        diamondkeytext.text = diamondkeyhave + "/" + diamondkeyamount;
        starkeytext.text = starkeyhave + "/" + starkeyamount;
        if ((skeletonkeyhave >= skeletonkeyamount) && (bonekeyhave >= bonekeyamount) && (diamondkeyhave >= diamondkeyamount) && (starkeyhave >= starkeyamount))
        {
           // Destroy(GameObject.FindWithTag("door"));
           Destroy(door);
        }
        
        //pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
               if (gameispause)
                   {
                     PResume();
                   }
               else
                   {
                     PPause();
                   }
        }


        if (diedUI.activeSelf == true)
        {
            pausemenuUI.SetActive(false);
            winUI.SetActive(false);
        }
        if (winUI.activeSelf == true)
        {
            pausemenuUI.SetActive(false);
            diedUI.SetActive(false);
        }


        if ( (pausemenuUI.activeSelf == true) || (diedUI.activeSelf == true) || (winUI.activeSelf == true) )
        {
            Time.timeScale = 0f;
            gameispause = true;
        }
        else
        {
            Time.timeScale = 1f;
        }
        
          
        //diedcount.text = ": "+died;



        if (File.Exists(file))
        {
            string str = File.ReadAllText(file);
            Console.WriteLine(str);
            died = Int16.Parse(str);

            // Read all the content in one string 
            // and display the string 

        }
        
        

    }

    
    private void playerDied()
    {
        diedUI.SetActive(true);
        PPause();
        died = died + 1;

        
        
    }
  
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "skeletonkey")
        {
            
            player_soundeffectplayer.pickupkey();
            skeletonkeyhave++;
            //skeletonkeytext.text = ""+skeletonkey;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "bonekey")
        {

            player_soundeffectplayer.pickupkey();
            bonekeyhave++;
            //skeletonkeytext.text = ""+skeletonkey;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "starkey")
        {

            player_soundeffectplayer.pickupkey();
            starkeyhave++;
            //skeletonkeytext.text = ""+skeletonkey;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "diamondkey")
        {

            player_soundeffectplayer.pickupkey();
            diamondkeyhave++;
            //skeletonkeytext.text = ""+skeletonkey;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "goal")
        {
            //youwin.text = "YOU WIN!!";
            winUI.SetActive(true);
            //PPause();
            SendMessage("win");
        }



        //enermy collision

        if (collision.gameObject.tag == "enemies")
        {
            player_soundeffectplayer.monstercollission();
            playerDied();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (collision.gameObject.tag == "ants")
        {
            player_soundeffectplayer.antscollission();
            playerDied();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //portal
        if (collision.gameObject.tag == "teleporter")
        {

            player_soundeffectplayer.wave();
           
        }

        if (collision.gameObject.tag=="walls")
        {
            //Debug.Log("");
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(-speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, -speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, speed, 0, 0);
            }
        }
    }
}
