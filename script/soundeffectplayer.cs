using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeffectplayer : MonoBehaviour
{
    public player player_soundeffectplayer;
    //public portalcontroller portalcontroller_soundeffectplayer;
    public AudioSource SFX;
    public AudioClip keypickup;
    public AudioClip monstersound;
    public AudioClip antssound;
    public AudioClip buttonclicksound;
    public AudioClip wavesound;
    public void pickupkey()
    {
        SFX.clip = keypickup;
        SFX.Play();
    }
    public void monstercollission()
    {
        SFX.clip = monstersound;
        SFX.Play();
    }
    public void antscollission()
    {
        SFX.clip = antssound;
        SFX.Play();
    }
    public void buttonclick()
    {
        SFX.clip = buttonclicksound;
        SFX.Play();
    }
    public void wave()
    {
        SFX.clip = wavesound;
        SFX.Play();
    }
}



