using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTarget : MonoBehaviour
{
    private GameObject player;
    public Transform target;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");


        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //target = player.transform.position;
       // agent.SetDestination(player.position);

    }
}
