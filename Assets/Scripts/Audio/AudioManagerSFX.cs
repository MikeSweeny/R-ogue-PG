using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerSFX : MasterAudioManager
{    
    //Current SFX Playing
    private AudioSource currentSFX;

    //List of SFX audio
    public AudioClip playerHitSFX;
    public AudioClip playerDeathSFX;
    public AudioClip playerJumpSFX;
    public AudioClip enemyHitSFX1;
    public AudioClip enemyHitSFX2;
    public AudioClip enemyHitSFX3;
    public AudioClip enemyDeathSFX1;
    public AudioClip enemyDeathSFX2;
    public AudioClip enemyDeathSFX3;
    public AudioClip spellCast1;
    public AudioClip spellCast2;
    public AudioClip spellCast3;
    public AudioClip enemySpellCast1;
    public AudioClip enemySpellCast2;
    public AudioClip enemySpellCast3;
    public AudioClip torchAudio;
    public AudioClip perkDaisAudio;
    public AudioClip leverSFX;
    public AudioClip perkPickUpSFX;
    public AudioClip boneDropped;
    public AudioClip boneCollected;
    public AudioClip buttonPress;
    public AudioClip pauseEnter;
    public AudioClip pauseExit;

    //Instance of Audio Manager
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
    public void PlayerHitSFX()
    {
        currentSFX.clip = playerHitSFX;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void PlayerDeathSFX()
    {
        currentSFX.clip = playerDeathSFX;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void PlayerJumpSFX()
    {
        currentSFX.clip = playerJumpSFX;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void SpellCastSFX1()
    {
        currentSFX.clip = spellCast1;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void SpellCastSFX2()
    {
        currentSFX.clip = spellCast2;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void SpellCastSFX3()
    {
        currentSFX.clip = spellCast3;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void EnemyHitSFX1()
    {
        currentSFX.clip = enemyHitSFX1;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void EnemyHitSFX2()
    {
        currentSFX.clip = enemyHitSFX2;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void EnemyHitSFX3()
    {
        currentSFX.clip = enemyHitSFX3;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void EnemyDeathSFX1()
    {
        currentSFX.clip = enemyDeathSFX1;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void EnemyDeathSFX2()
    {
        currentSFX.clip = enemyDeathSFX2;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void EnemyDeathSFX3()
    {
        currentSFX.clip = enemyDeathSFX3;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void EnemySpellCastSFX1()
    {
        currentSFX.clip = enemySpellCast1;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void EnemySpellCastSFX2()
    {
        currentSFX.clip = enemySpellCast2;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void EnemySpellCastSFX3()
    {
        currentSFX.clip = enemySpellCast3;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void TorchSFX()
    {
        currentSFX.clip = torchAudio;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void PerkDaisSFX()
    {
        currentSFX.clip = perkDaisAudio;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void LeverSFX()
    {
        currentSFX.clip = leverSFX;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void PerkPickUpSFX()
    {
        currentSFX.clip = perkPickUpSFX;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void BoneDroppedSFX()
    {
        currentSFX.clip = boneDropped;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void BoneCollectedSFX()
    {
        currentSFX.clip = boneCollected;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void ButtonPressedSFX()
    {
        currentSFX.clip = buttonPress;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void PauseEnterSFX()
    {
        currentSFX.clip = pauseEnter;
        currentSFX.Play();
        currentSFX.Stop();
    }
    public void PauseExitSFX()
    {
        currentSFX.clip = pauseExit;
        currentSFX.Play();
        currentSFX.Stop();
    }
}
