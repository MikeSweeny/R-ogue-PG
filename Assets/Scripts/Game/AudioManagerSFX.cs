using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerSFX : MonoBehaviour
{
    public AudioSource SFXSource;
    public static AudioManagerSFX instance = null;                


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void PlaySingleSFX(AudioClip clip)
    {
        SFXSource.clip = clip;
        SFXSource.Play();
    }
}
