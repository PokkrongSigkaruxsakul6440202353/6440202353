using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public TextMeshProUGUI timertext;
    private float startTime;
    private bool winned = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (winned)
            return;

        float t = Time.time-startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t%60).ToString("f2");
        timertext.text = (minutes +":"+ seconds);
    }
    public void win()
    {
        winned = true;
        timertext.color = Color.red;
    }


}
