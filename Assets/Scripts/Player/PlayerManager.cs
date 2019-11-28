using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    bool perkPoint = true;

    // Basic Stats
    int health;
    int bones;
    int jumpCount;
    int lifesteal;
    int projMod_SpreadCount;
    float attackCD;
    float defence;
    float projMod_Speed;
    float projMod_Damage;
    float projMod_Spread;

    // Toggleable Perks
    bool seeking = false;
    bool magnet = false;
    bool lottery = false;
    bool levitate = false;
    bool explosive = false;
    bool hover = false;

    // References to self
    Rigidbody body;
    PlayerController controller;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        controller = GetComponent<PlayerController>();
    }
}
