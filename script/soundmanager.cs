using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundmanager : MonoBehaviour
{
    [SerializeField] Slider musicslider;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else 
        { 
            Load();
        }
    }

    public void ChangeMusicVolume()
    {
        AudioListener.volume = musicslider.value;
        Save();
    }

    private void Load()
    {
        musicslider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume",musicslider.value);
    }
}
