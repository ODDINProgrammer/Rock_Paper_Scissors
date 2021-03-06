using UnityEngine;
using UnityEngine.Audio;

public class Pause_panel : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup Mixer;
    private float currentVolume = -40;

    private void OnEnable()
    {
        Time.timeScale = 0;        
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }

    public void TogleMusic(bool enabled)
    {
        //  ON
        if (enabled)
            Mixer.audioMixer.SetFloat("Master", currentVolume);

        //  OFF
        else
            Mixer.audioMixer.SetFloat("Master", -80);
    }

    public void AdjustVolume(float volume)
    {
        currentVolume = volume;
        Mixer.audioMixer.SetFloat("Master", volume);
    }
}
