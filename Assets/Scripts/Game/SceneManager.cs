using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Public references to anything in the scene
    PlayerController playerController;
    PlayerManager playerManager;

    public static SceneManager Instance { get; private set; } // static singleton
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        // Cache references to all desired variables
        playerController = FindObjectOfType<PlayerController>();
        playerManager = FindObjectOfType<PlayerManager>();
    }

    PlayerManager GetPlayerManager()
    {
        return playerManager;
    }

    PlayerController GetPlayerController()
    {
        return playerController;
    }
}
