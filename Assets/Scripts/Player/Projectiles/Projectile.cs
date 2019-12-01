using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    PlayerManager playerManager;

    float projMod_Speed;
    float projMod_Damage;
    float projMod_Spread;

    bool seeking = false;
    bool magnet = false;
    bool explosive = false;

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
        // Making projectiles choose a random spot in a cone range from player.head.forward +/- projMod_Spread

        Vector3 spawnPos = playerManager.transform.position + (playerManager.transform.forward) + (playerManager.transform.right);
        transform.position = (spawnPos);
        transform.forward = playerManager.head.transform.forward;

        projMod_Speed = playerManager.GetProjSpeed();
        projMod_Damage = playerManager.GetProjDamage();
        projMod_Spread = playerManager.GetProjSpread();
        seeking = playerManager.GetActivePerks("seeking");
        magnet = playerManager.GetActivePerks("magnet");
        explosive = playerManager.GetActivePerks("explosive");
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
        inAir = false;
        ReturnToPool();
        if (other.gameObject.CompareTag("Enemy"))
        {
            //ApplyDamage();
        }
    }

    void ReturnToPool()
    {
        inPool = true;
        gameObject.SetActive(false);
    }
}
