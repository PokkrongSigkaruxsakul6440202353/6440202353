using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using UnityEngine.UI;

public class deathcount : MonoBehaviour
{
    
    string file = Application.dataPath + "/deathcount.txt";


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

            
        }

        var f = new FileInfo(file);
        if (f.Length == 0)
        {
            TextWriter tw = new StreamWriter(file, false);
            tw.Write(string.Empty);
            tw.Write("0");
            tw.Close();
        }


    }

    public void clear()
    {
        if (!File.Exists(file))
            File.Create(file);

        TextWriter tw = new StreamWriter(file, false);
        tw.Write(string.Empty);
        tw.Write("0");
        tw.Close();
    }
}
