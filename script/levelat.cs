using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class levelat : MonoBehaviour
{
    public Button continuebutton;
    string file = Application.dataPath+"/levelat.txt";
    

    // Start is called before the first frame update
    void Start()
    {
     
            

    }

    // Update is called once per frame
    void Update()
    {
        
        if (File.Exists(file))
        {
            // Read all the content in one string 
            // and display the string 
            string str = File.ReadAllText(file);
            Console.WriteLine(str);
        }
        if (!File.Exists(file))
        {
            
            continuebutton.interactable = false;
        }

        var f = new FileInfo(file);
        if (f.Length == 0)
        {
            TextWriter tw = new StreamWriter(file, false);
            tw.Write(string.Empty);
            tw.Write("1");
            tw.Close();
        }


    }

    public void newgame()
    {
        if (!File.Exists(file))
            File.Create(file);

        TextWriter tw = new StreamWriter(file, false);
        tw.Write(string.Empty);
        tw.Write("1");
        tw.Close();
    }
}
