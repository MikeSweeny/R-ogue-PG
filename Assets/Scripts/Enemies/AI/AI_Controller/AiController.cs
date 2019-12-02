using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiController : MonoBehaviour
{
    public AI_StateAttacking stateAttacking { get; set; }
    public AI_StateChasing stateChasing { get; set; }
    public AI_StateDead stateDead { get; set; }


    public AIState currentState;

    private Animator _animator;

    private float x = 0;
    private float y = 0;

    public Transform target;

    private Collider attackRange;
    private NavMeshAgent agent;
    private bool isAttacking = false;

    private Rigidbody myRigidbody;

    private Vector3 myVelocity;

    private void Awake()
    {
        stateChasing = new AI_StateChasing(this);
        stateAttacking = new AI_StateAttacking(this);
        stateDead = new AI_StateDead(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        NewAIState(stateChasing);

        _animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        attackRange = GetComponentInChildren<SphereCollider>();
        
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == stateChasing)
        {


            agent.SetDestination(target.position);

            myVelocity = myRigidbody.velocity;

            if (myVelocity.z > 0)
            {
                x = x + 0.1f;
                if (myVelocity.z >= 1)
                {
                    x = 1;
                }

            }
            else if (myVelocity.z < 0)
            {
                x = x - 0.1f;
                if (myVelocity.z <= -1)
                {
                    x = -1;
                }
            }

            if (myVelocity.x > 0)
            {
                y = y + 0.1f;
                if (myVelocity.x >= 1)
                {
                    y = 1;
                }
            }
            else if (myVelocity.x < 0)
            {
                y = y - 0.1f;
                if (myVelocity.x <= -1)
                {
                    y = -1;
                }
            }
            EnemyMovement(x, y);
        }
        if (currentState == stateAttacking)
        {
            _animator.SetBool("isAttacking", true);
            
            x = 1;

        }
        else
        {
            _animator.SetBool("isAttacking", false);

        }

        if (currentState == stateDead)
        {
            x = 0;
            y = 0;
            EnemyMovement(x, y);


            this.gameObject.SetActive(false);
        }
    }
    public void NewAIState(AIState newState)
    {
        if(currentState != null)
        {
            currentState.StateExit();
        }
        currentState = newState;
        currentState.StateEnter();
    }
    
    private void EnemyMovement(float x, float y)
    {
        _animator.SetFloat("VelX", x);
        _animator.SetFloat("VelY", y);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "ModelPlayer_T-Pose")
        {
            NewAIState(stateAttacking);

           // _animator.SetBool("isAttacking", true);
        }
        /*if (other.gameObject.tag == "Enemy");
        {

        }*/
    }



}
