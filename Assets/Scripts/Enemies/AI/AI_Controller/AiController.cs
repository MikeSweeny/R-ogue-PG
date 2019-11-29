using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{
    private Animator _animator;

    private float x = 0;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        /*if (_animator = null)
        {
            return;
        }*/

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        Vector3 myVelocity = rigidbody.velocity;

        //x = myVelocity.x;
        //y = myVelocity.y;
      
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
    
    private void EnemyMovement(float x, float y)
    {
        _animator.SetFloat("VelX", x);
        _animator.SetFloat("VelY", y);

        Debug.Log(x);

    }

    
}
