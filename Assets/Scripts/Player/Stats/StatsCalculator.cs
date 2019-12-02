using System;
using UnityEngine;

public class StatsCalculator : MonoBehaviour
{
    // Stat Stuff //
    [SerializeField]
    int MaxHealth;
    [SerializeField]
    int currentHealth;
    [SerializeField]
    int bones;
    [SerializeField]
    int jumpCount;
    [SerializeField]
    int lifesteal;
    [SerializeField]
    int projMod_SpreadCount;
    [SerializeField]
    float attackCD;
    [SerializeField]
    float defense;
    [SerializeField]
    float projMod_Speed;
    [SerializeField]
    float projMod_Damage;
    [SerializeField]
    float projMod_Spread;
    // ------------ //

    // Perk Stuff //

    PlayerManager player;
    private void Start()
    {
        getStats();
    }
    private void Awake()
    {

    }
    private void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        
    }
    void getStats()
    {
        player = SceneManager.Instance.playerManager;
        currentHealth = player.GetHealth();
        MaxHealth = player.GetMaxHealth();
        bones = player.GetBones();
        jumpCount = player.GetJumpCount();
        lifesteal = player.GetLifestealPercent();
        projMod_SpreadCount = player.GetProjSpreadCount();
        attackCD = player.GetAttackCD();
        defense = player.GetDefense();
        projMod_Speed = player.GetProjSpeed();
        projMod_Damage = player.GetProjDamage();
        projMod_Spread = player.GetProjSpread();

    }
}
