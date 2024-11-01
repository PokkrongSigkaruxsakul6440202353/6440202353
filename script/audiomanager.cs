using UnityEngine;
using UnityEngine.UI;

public class audiomanager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectPref = "SoundEffectPref";
    private int firstPlayInt;
    public Slider backgroundSlider, soundeffectsSlider;
    private float backgroundfloat, soundEffectsFloat;
    public AudioSource backgroundAudio;

    public AudioSource[] soundEffectsAudio;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);
        if(firstPlayInt ==0)
        {
            backgroundfloat = .125f;
            soundEffectsFloat = .75f;
            backgroundSlider.value = backgroundfloat;
            soundeffectsSlider.value = soundEffectsFloat;
            PlayerPrefs.SetFloat(BackgroundPref,backgroundfloat);
            PlayerPrefs.SetFloat(SoundEffectPref,soundEffectsFloat);
            PlayerPrefs.SetInt(FirstPlay,-1);
        }
        else
        {
           backgroundfloat = PlayerPrefs.GetFloat(BackgroundPref);
           backgroundSlider.value = backgroundfloat;
           soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectPref);
            soundeffectsSlider.value= soundEffectsFloat;
        }
    }

    public void SaveSoundSetting()
    {
        PlayerPrefs.SetFloat(BackgroundPref, backgroundSlider.value);
        PlayerPrefs.SetFloat(SoundEffectPref, soundeffectsSlider.value);
    }

    void OnApplicationFocus(bool infocus)
    {
        if(!infocus) 
        {
            SaveSoundSetting();
        }
    }

    public void UpdateSound()
    {
       
        
            backgroundAudio.volume = backgroundSlider.value;
        
        for (int j = 0;j<soundEffectsAudio.Length;j++) 
        {
            soundEffectsAudio[j].volume = soundeffectsSlider.value;
        }
    }
}
