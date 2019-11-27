using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{

    Resolution[] resolutions;
    public Dropdown resolutuonDropdown;

    public AudioMixer audioMixer;

    private void Start()
    {
        resolutions = Screen.resolutions;

        resolutuonDropdown.ClearOptions();
        int currentResolutionIndex = 0;
        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutuonDropdown.AddOptions(options);
        resolutuonDropdown.value = currentResolutionIndex;
        resolutuonDropdown.RefreshShownValue();
    }
    // to Set our volume
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Master", volume);
        Debug.Log("Main Volume Level: " + volume);
    }
    public void ToggleMasterVolume(bool IsToggled)
    {
        audioMixer.SetFloat("Master", -80);
    }

    public void SetSoundVolume(float Soundvolume)
    {
        audioMixer.SetFloat("SFX", Soundvolume);
        Debug.Log("Sounds Volume Level: " + Soundvolume);
    }
    public void SetMusicVolume(float Musicvolume)
    {
        audioMixer.SetFloat("BKGMusic", Musicvolume);

        Debug.Log("Music Volume Level: " + Musicvolume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
