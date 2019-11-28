using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform headPosition;
    float lookRotation;
    Rigidbody body;

    float moveSpeed = 15f;


    private void Start()
    {
        body = GetComponent<Rigidbody>();
        headPosition = transform.GetChild(0).transform;
    }

    private void Update()
    {
        //Making the body follow the head only on y axis
        lookRotation = headPosition.rotation.eulerAngles.y;
        var newRot = new Vector3(body.rotation.eulerAngles.x, lookRotation, body.rotation.eulerAngles.z);
        var currentRot = Quaternion.Euler(newRot);
        body.rotation = currentRot;

        //Making the body move according to axis input (should work for controllers too)
        var h = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        var v = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        var newPos = new Vector3(h, 0, v); //Player.transform.rotation* Vector3.forward

        newPos = newPos.normalized * moveSpeed * Time.deltaTime;
        newPos = transform.worldToLocalMatrix.inverse * newPos;
        body.MovePosition(transform.position + newPos);
        //transform.position += newPos;
    }
}
