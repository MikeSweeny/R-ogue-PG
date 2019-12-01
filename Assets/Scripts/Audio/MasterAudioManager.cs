using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MasterAudioManager : MonoBehaviour
{
    public AudioMixer masterMixer;

    public void MuteAll()
    {
        masterMixer.SetFloat("MasterVolume", 0);
        masterMixer.SetFloat("SFXVolume", 0);
        masterMixer.SetFloat("MusicVolume", 0);
    }
    public void MuteSFX()
    {
        masterMixer.SetFloat("SFXVolume", 0);
    }
    public void MuteMusic()
    {
        masterMixer.SetFloat("MusicVolume", 0);
    }
    public void SetMasterVolume(float masterSliderVolume)
    {
        masterMixer.SetFloat("MasterVolume", masterSliderVolume);
    }
    public void SetSFXVolume(float sfxSliderVolume)
    {
        masterMixer.SetFloat("SFXVolume", sfxSliderVolume);
    }
    public void SetMusicVolume(float musicSliderVolume)
    {
        masterMixer.SetFloat("MusicVolume", musicSliderVolume);
    }
}
