using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    PlayerManager playerManager;

    float attackCD;
    float defense;
    float projMod_Speed;
    float projMod_Damage;
    float projMod_Spread;

    bool seeking = false;
    bool magnet = false;
    bool lottery = false;
    bool levitate = false;
    bool explosive = false;
    bool hover = false;


    // Start is called before the first frame update
    private void Awake()
    {

    }

    void Start()
    {
        playerManager = SceneManager.Instance.GetPlayerManager();
    }

    private void OnEnable()
    {
        if (playerManager)
        {
            transform.position = (playerManager.transform.forward * 3);
            transform.LookAt(-(playerManager.transform.forward));

            attackCD = playerManager.GetAttackCD();
            defense = playerManager.GetDefense();
            projMod_Speed = playerManager.GetProjSpeed();
            projMod_Damage = playerManager.GetProjDamage();
            projMod_Spread = playerManager.GetProjSpread();
            seeking = playerManager.GetActivePerks("seeking");
            magnet = playerManager.GetActivePerks("magnet");
            lottery = playerManager.GetActivePerks("lottery");
            levitate = playerManager.GetActivePerks("levitate");
            explosive = playerManager.GetActivePerks("explosive");
            hover = playerManager.GetActivePerks("hover");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * projMod_Speed * Time.deltaTime;
    }
}
