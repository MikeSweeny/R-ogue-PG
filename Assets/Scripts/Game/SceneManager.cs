using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Public references to anything in the scene
    public PlayerController playerController;
    public PlayerManager playerManager;

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
        //playerController = FindObjectOfType<PlayerController>();
        //playerManager = gameObject.transform.GetChild(0).GetComponent<PlayerManager>();
    }

    public PlayerManager GetPlayerManager()
    {
        return playerManager;
    }

    public PlayerController GetPlayerController()
    {
        return playerController;
    }
}
