using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowTarget : MonoBehaviour
{
    public Transform target;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();

        //agent.updatePosition = false;

    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 currentPosition = agent.nextPosition - transform.position;

        float dx = Vector3.Dot(transform.right, currentPosition);
        float dy = Vector3.Dot(transform.forward, currentPosition);
        Vector2 deltaPosition = new Vector2(dx, dy);*/

        //target = SceneManager.Instance.GetPlayerController().transform.position;

        agent.SetDestination(target.position);

    }
}
