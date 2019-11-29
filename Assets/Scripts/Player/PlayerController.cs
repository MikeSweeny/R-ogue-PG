using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Interactable interactObject;
    Transform headPosition;
    float lookRotation;
    Rigidbody body;

    float fallSpeedAdjustor = 2000;
    float jumpPower = 50000;
    float moveSpeed = 30f;

    PlayerManager playerManager;

    private void Start()
    {
        playerManager = SceneManager.playerManager;
        body = GetComponent<Rigidbody>();
        headPosition = transform.GetChild(0).transform;
    }

    private void Awake()
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
        var newPos = new Vector3(h, 0, v);

        newPos = newPos.normalized * moveSpeed * Time.deltaTime;
        newPos = transform.worldToLocalMatrix.inverse * newPos;
        body.MovePosition(transform.position + newPos);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject tempProj = playerManager.projectilePool.FetchObjectFromPool();
            tempProj.gameObject.SetActive(true);

            Debug.Log("PEW");
        }
        if (Input.GetButtonDown("Jump"))
        {
            body.AddForce(body.transform.up * jumpPower);
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

    public void SetInteractObject(Interactable iObj)
    {
        interactObject = iObj;
    }
}
