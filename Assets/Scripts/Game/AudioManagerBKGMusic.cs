using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerBKGMusic : MonoBehaviour
{
    public AudioSource BKGMusicSource;
    public static AudioManagerBKGMusic instance = null;

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
    public void PlaySingleBKGMusic(AudioClip clip)
    {
        BKGMusicSource.clip = clip;
        BKGMusicSource.Play();
    }
}
