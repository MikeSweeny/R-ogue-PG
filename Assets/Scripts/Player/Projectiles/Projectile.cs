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
        playerManager = SceneManager.playerManager;
    }

    void Start()
    {
        
    }

    private void OnEnable()
    {
        Vector3 spawnPos = playerManager.transform.position + (playerManager.transform.forward) + (playerManager.transform.right);
        transform.position = (spawnPos);
        //transform.LookAt(-playerManager.head.transform.forward);
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
