using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _animator;
    float attackAnimTime;
    float attackCurrentTime;


    Interactable interactObject;
    Transform headPosition;
    float lookRotation;
    Rigidbody body;

    float fallSpeedAdjustor = 1000;
    float jumpPower = 50000;
    float moveSpeed = 20f;

    PlayerManager playerManager;

    private void Start()
    {
        playerManager = SceneManager.Instance.GetPlayerManager();
        body = GetComponent<Rigidbody>();
        headPosition = transform.GetChild(0).transform;
        _animator = GetComponentInChildren<Animator>();
    }

    private void Awake()
    {

    }

    private void FixedUpdate()
    {

    }

    private void Update()
    {
        // Making the body fall faster after jumping
        if (body.velocity.y <= 0.4)
        {
            body.AddForce((-body.transform.up) * fallSpeedAdjustor);
        }

        //Making the body follow the head only on y axis
        lookRotation = headPosition.rotation.eulerAngles.y;
        var newRot = new Vector3(body.rotation.eulerAngles.x, lookRotation, body.rotation.eulerAngles.z);
        var currentRot = Quaternion.Euler(newRot);
        body.rotation = currentRot;

        //Making the body move according to axis input (should work for controllers too)
        var h = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        var v = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        PlayerAnimMovement(x, y);

        var newPos = new Vector3(h, 0, v);

        newPos = newPos.normalized * moveSpeed * Time.deltaTime;
        newPos = transform.worldToLocalMatrix.inverse * newPos;
        body.MovePosition(transform.position + newPos);


           
        // Other input controls
        if (Input.GetButtonDown("Fire1"))
        {
            //Animation anim = Animator.GetCurrentAnimatorClipInfo
            //_animator.StopPlayback();

            //_animator.SetBool("isAttacking", true);


            //_animator.SetBool("isAttacking", true);

            //attackAnimTime = _animator.GetCurrentAnimatorStateInfo(0).length;
            _animator.ResetTrigger("isAttacking");

            _animator.SetTrigger("isAttacking");


            for (int i = 0; i < playerManager.GetProjSpreadCount(); i++)
            {
                GameObject tempProj = playerManager.projectilePool.FetchObjectFromPool();
                tempProj.gameObject.SetActive(true);

                Debug.Log("PEW");
            }
        

        } 
        /*attackCurrentTime = _animator.GetCurrentAnimatorStateInfo(0).normalizedTime;
        if (attackCurrentTime >= attackAnimTime)
        {
            _animator.SetBool("isAttacking", false);

        }*/

        if (Input.GetButtonDown("Jump"))
        {
            if (playerManager.GetNumTimesJumped() >= playerManager.GetJumpCount())
            {
                return;
            }
            else
            {
                body.AddForce(body.transform.up * jumpPower);
                playerManager.IncrementTimesJumped();
            }
        }
        if (Input.GetButtonDown("Interact"))
        {
            if (interactObject)
            {
                interactObject.Act();

                Debug.Log("Successful Interaction with: " + interactObject);
            }
        }
        if (Input.GetButtonDown("Cancel"))
        {
            // Pause Menu?(probably not)  --  State Change?(probably)
        }
    }
    private void PlayerAnimMovement(float x, float y)
    {
        _animator.SetFloat("VelX", x);
        _animator.SetFloat("VelY", y);
    }

    public void SetInteractObject(Interactable iObj)
    {
        interactObject = iObj;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            playerManager.SetIsGrounded(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            playerManager.SetIsGrounded(false);
        }
    }
}
