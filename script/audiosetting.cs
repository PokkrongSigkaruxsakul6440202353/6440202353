using UnityEngine;

public class audiosetting : MonoBehaviour
{
    private static readonly string BackgroundPref = "BackgroundPref";
    private static readonly string SoundEffectPref = "SoundEffectPref";
    private float backgroundfloat, soundEffectsFloat;
    public AudioSource backgroundAudio;
    public AudioSource[] soundEffectsAudio;
    void Awake()
    {
        continueSettings();
    }

    private void continueSettings()
    {
        backgroundfloat = PlayerPrefs.GetFloat(BackgroundPref);
        soundEffectsFloat = PlayerPrefs.GetFloat(SoundEffectPref);

        

        
            backgroundAudio.volume = backgroundfloat;
        

        for (int j = 0; j < soundEffectsAudio.Length; j++)
        {
            soundEffectsAudio[j].volume = soundEffectsFloat;
        }
    }

}
