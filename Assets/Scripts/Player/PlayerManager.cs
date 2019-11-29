using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    bool perkPoint = true;
    float rayCastLength = 10;
    RaycastHit forwardRaycastHit;
    GameObject nearbyInteractable;
    GameObject head;

    // Basic Stats
    int currentHealth;
    int maxHealth;
    int bones;
    int jumpCount = 1;
    int lifesteal;
    int projMod_SpreadCount;
    float attackCD;
    float defense;
    float projMod_Speed;
    float projMod_Damage;
    float projMod_Spread = 5f;

    // Toggleable Perks
    bool seeking = false;   // Call by these names in strings
    bool magnet = false;    // Call by these names in strings
    bool lottery = false;   // Call by these names in strings
    bool levitate = false;  // Call by these names in strings
    bool explosive = false; // Call by these names in strings
    bool hover = false;     // Call by these names in strings

    // References to self
    Rigidbody body;
    PlayerController controller;

    private void Start()
    {
        head = gameObject.transform.GetChild(0).gameObject;
        body = GetComponent<Rigidbody>();
        controller = GetComponent<PlayerController>();
    }

    private void Update()
    {
        SetRaycastHitTarget();
        if (nearbyInteractable && GetRaycastHit())
        {
            if (forwardRaycastHit.transform.gameObject.CompareTag("Interactable"))
            {
                SceneManager.Instance.GetPlayerController().SetInteractObject(forwardRaycastHit.transform.gameObject.GetComponent<Interactable>());
            }
        }
        else
        {
            SceneManager.Instance.GetPlayerController().SetInteractObject(null);
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
}
