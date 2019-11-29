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

    // Bools to be replaced by state machine
    public bool inAir;
    public bool inPool;
    public bool hit;

    private void Awake()
    {
        playerManager = SceneManager.Instance.GetPlayerManager();
    }

    void Start()
    {
        
    }

    private void OnEnable()
    {
        Vector3 spawnPos = playerManager.transform.position + (playerManager.transform.forward * 3);
        transform.position = (spawnPos);
        transform.LookAt(-playerManager.transform.forward);

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
        inAir = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (inAir)
        {
            transform.position += transform.forward * projMod_Speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //ApplyDamage();
            inAir = false;
            ReturnToPool();
        }
    }

    void ReturnToPool()
    {
        inPool = true;
        gameObject.SetActive(false);
    }
}
