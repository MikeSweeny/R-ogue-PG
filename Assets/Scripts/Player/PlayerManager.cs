using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    bool perkPoint = true;  /// Starts with 1 perk point every game
    float rayCastLength = 10;
    RaycastHit forwardRaycastHit;
    GameObject nearbyInteractable;
    public GameObject head;

    // Basic Stats
    [SerializeField]
    int currentHealth;
    [SerializeField]
    int maxHealth;
    [SerializeField]
    int bones;
    [SerializeField]
    int jumpCount;
    [SerializeField]
    int numTimesJumped;
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
    [SerializeField]
    bool isGrounded = true;

    // Toggleable Perks
    bool seeking = false;   /// Call by these names in strings
    bool magnet = false;    /// Call by these names in strings
    bool lottery = false;   /// Call by these names in strings
    bool levitate = false;  /// Call by these names in strings
    bool explosive = false; /// Call by these names in strings
    bool hover = false;     /// Call by these names in strings

    // References to self
    Rigidbody body;
    PlayerController controller;

    // Misc player variables
    public ProjectilePool projectilePool;
    public GameObject pauseMenu;
    public PerkSystem perkSystem;
    SphereCollider newSphere;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();

        projectilePool = transform.GetChild(2).GetComponent<ProjectilePool>();
        projectilePool.PopulatePool();
    }


    private void Start()
    {
        head = gameObject.transform.GetChild(0).gameObject;
        body = GetComponent<Rigidbody>();
        // ****************** HERE IS THE BASE STATS ****************** //
        SetBaseStats();
    }
    private void SetBaseStats()
    {
        maxHealth = 1000;
        currentHealth = maxHealth;
        bones = 0;
        jumpCount = 1;
        lifesteal = 0;
        projMod_SpreadCount = 1;
        attackCD = 1.5f;
        defense = 10f;
        projMod_Speed = 50f;
        projMod_Damage = 5f;
        projMod_Spread = 5f;
    }
        // ****************** HERE IS THE BASE STATS ****************** //

    private void Update()
    {
        SetRaycastHitTarget();
        if (nearbyInteractable && GetRaycastHit())
        {
            if (forwardRaycastHit.transform.gameObject.CompareTag("Interactable"))
            {
                Debug.Log("Looking at: " + forwardRaycastHit.transform.gameObject);
                SceneManager.Instance.GetPlayerController().SetInteractObject(forwardRaycastHit.transform.parent.GetComponent<Interactable>());
            }
            else
            {
                SceneManager.Instance.GetPlayerController().SetInteractObject(null);
            }
        }
    }

    private bool GetRaycastHit()
    {
        return Physics.Raycast(head.transform.position, head.transform.forward);
    }
    private void SetRaycastHitTarget()
    {
        Physics.Raycast(head.transform.position, head.transform.forward, out forwardRaycastHit);
        Debug.DrawRay(head.transform.position, head.transform.forward.normalized * rayCastLength, new Color(1, 0, 0.25f, 1));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("InteractableRange"))
        {
            Debug.Log("Near Interactable");
            nearbyInteractable = other.gameObject;
        }
        var perk = other.GetComponent<Perks>();
        if (perk)
        {
            perkSystem.AddPerk(perk.perk, 1);
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("InteractableRange"))
        {
            nearbyInteractable = null;
        }
    }


    //              GETTERS AND SETTERS             //
    public void SetMaxHealth(int deltaHealth)
    {
        maxHealth += deltaHealth;
    }
    public int GetMaxHealth()
    {
        return maxHealth;
    }

    public void SetHealth(int deltaHealth)
    {
        currentHealth += deltaHealth;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }
    public int GetHealth()
    {
        return currentHealth;
    }

    public void SetBones(int deltaBones)
    {
        bones += deltaBones;
        if (bones <= 0)
        {
            bones = 0;
        }
    }
    public int GetBones()
    {
        return bones;
    }

    public void IncrementJumpCount()
    {
        jumpCount++;
    }
    public int GetJumpCount()
    {
        return jumpCount;
    }

    public void SetLifestealPercent(int deltaLifesteal)
    {
        lifesteal += deltaLifesteal;
    }
    public int GetLifestealPercent()
    {
        return lifesteal;
    }

    public void SetProjSpreadCount(int deltaSpreadCount)
    {
        projMod_SpreadCount += deltaSpreadCount;
    }
    public int GetProjSpreadCount()
    {
        return projMod_SpreadCount;
    }
    public float GetProjSpreadAngle()
    {
        return projMod_Spread;
    }

    public void SetAttackCD(float deltaCD)
    {
        attackCD += deltaCD;
    }
    public float GetAttackCD()
    {
        return attackCD;
    }

    public void SetDefense(float deltaDef)
    {
        defense += deltaDef;
    }
    public float GetDefense()
    {
        return defense;
    }

    public void SetProjSpeed(float deltaProjSpeed)
    {
        projMod_Speed += deltaProjSpeed;
    }
    public float GetProjSpeed()
    {
        return projMod_Speed;
    }

    public void SetProjDamage(float deltaProjDamage)
    {
        projMod_Damage += deltaProjDamage;
    }
    public float GetProjDamage()
    {
        return projMod_Damage;
    }

    public float GetProjSpread()
    {
        return projMod_Spread;
    }

    public bool GetIsGrounded()
    {
        return isGrounded;
    }

    public void SetIsGrounded(bool isOnG)
    {
        if (isOnG)
        {
            isGrounded = true;
            numTimesJumped = 0;
        }
        if (!isOnG)
        {
            isGrounded = false;
        }
    }
    public void IncrementTimesJumped()
    {
        numTimesJumped++;
    }

    public int GetNumTimesJumped()
    {
        return numTimesJumped;
    }

    public bool GetActivePerks(string name)
    {
        switch (name)
        {
            case "seeking":
                return seeking;
            case "magnet":
                return magnet;
            case "lottery":
                return lottery;
            case "levitate":
                return levitate;
            case "explosive":
                return explosive;
            case "hover":
                return hover;
            default:
                return false;
        }
    }

    public void ActivatePerk(string name)
    {
        switch (name)
        {
            case "seeking":
                seeking = true;
                break;
            case "magnet":
                magnet = true;
                break;
            case "lottery":
                lottery = true;
                break;
            case "levitate":
                levitate = true;
                break;
            case "explosive":
                explosive = true;
                break;
            case "hover":
                hover = true;
                break;
            default:
                break;
        }
    }

    private void OnApplicationQuit()
    {
        //perkSystem.container.perk.Clear();
    }
}
