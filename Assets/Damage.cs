using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    float counter;
    float attackCD = 3f;
    int damage = 5; //this is a stat you will have to give the AI (as well as maxHealth and currentHealth, these two with getters/setters)

    PlayerManager pM; //this can go away because your AiController already has a reference to playerManager
    public void Start()
    {
        pM = SceneManager.Instance.GetPlayerManager(); // same with this
        counter = attackCD; // This makes it so the enemy attacks as soon as it gets in range, then resets the timer
    }
    public void OnTriggerStay(Collider other)
    {
        // Counts up if player stays in range of the trigger box
        if(other.gameObject.tag == "Player")
        {
            counter += Time.deltaTime;
            if (counter >= attackCD)
            {
                DealDamage(damage);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // also resets cooldown if they have to move towards the player
        counter = 0;
    }

    public void DealDamage(int damage)
    {
        Debug.Log("Hit player for: " + damage + " damage.");
        pM.SetHealth(-damage);
        counter = 0;
    }
}
