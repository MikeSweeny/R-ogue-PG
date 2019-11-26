using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerBKGMusic : MonoBehaviour
{
    //Current Song Playing
    private AudioSource currentSong;

    //List of background audio
    public AudioClip startScreen;
    public AudioClip tutorialState;
    public AudioClip winScreen;
    public AudioClip deathScreen;
    public AudioClip battleState;
    public AudioClip ritualRoomState;

    //Instance of Audio Manager
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

    public void PlayStartScreenSong()
    {
        currentSong.Stop();
        currentSong.clip = startScreen;
        currentSong.Play();
    }
    public void PlayDeathScreenSong()
    {
        currentSong.Stop();
        currentSong.clip = deathScreen;
        currentSong.Play();
    }
    public void PlayWinScreenSong()
    {
        currentSong.Stop();
        currentSong.clip = winScreen;
        currentSong.Play();
    }
    public void PlayTutorialStateSong()
    {
        currentSong.Stop();
        currentSong.clip = tutorialState;
        currentSong.Play();
    }
    public void PlayBattleStateSong()
    {
        currentSong.Stop();
        currentSong.clip = battleState;
        currentSong.Play();
    }
    public void PlayRitualRoomStateSong()
    {
        currentSong.Stop();
        currentSong.clip = ritualRoomState;
        currentSong.Play();
    }
    public void StopSong()
    {
        currentSong.Stop();
    }
}
