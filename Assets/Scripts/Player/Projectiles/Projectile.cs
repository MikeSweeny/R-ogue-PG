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
        // Updateing the projectile's info before launching
        projMod_Speed = playerManager.GetProjSpeed();
        projMod_Damage = playerManager.GetProjDamage();
        projMod_Spread = playerManager.GetProjSpread();
        seeking = playerManager.GetActivePerks("seeking");
        magnet = playerManager.GetActivePerks("magnet");
        explosive = playerManager.GetActivePerks("explosive");
        inAir = true;

        // Making projectiles choose a random spot in a cone range from player.head.forward +/- projMod_Spread
        Vector3 spawnPos = playerManager.transform.position + (playerManager.transform.forward) + (playerManager.transform.right);
        transform.position = (spawnPos);
        Vector3 lookPos = playerManager.head.transform.forward;
        lookPos.x = Random.Range(lookPos.x - projMod_Spread, lookPos.x + projMod_Spread);
        lookPos.y = Random.Range(lookPos.y - projMod_Spread, lookPos.y + projMod_Spread);
        transform.forward = lookPos;
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
        if (!(other.gameObject.CompareTag("Projectile")))
        {
            inAir = false;
            ReturnToPool();
            if (other.gameObject.CompareTag("Enemy"))
            {
                //ApplyDamage();
            }
        }
    }

    void ReturnToPool()
    {
        inPool = true;
        gameObject.SetActive(false);
    }
}
