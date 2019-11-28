using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    public Transform player;
    public float rotationDamping = 3f;
    public float heightDamping = 2f;
    private float desiredAngle = 0;
    private float distance = 8;
    private float desiredDistance;
    private float height = 3.75f;
    private bool cameraReset = false;

    private void Start()
    {
        desiredDistance = distance;
    }

    private void FixedUpdate()
    {
        float currentAngle = transform.eulerAngles.y;
        float currentHeight = transform.position.y;

        desiredAngle = player.eulerAngles.y;
        
        currentAngle = Mathf.LerpAngle(currentAngle, desiredAngle, rotationDamping * Time.deltaTime);

        Quaternion currentRotation = Quaternion.Euler(0, currentAngle, 0);

        Vector3 finalPosition = player.position - (currentRotation * Vector3.forward * distance);
        finalPosition.y = currentHeight;
        transform.position = finalPosition;
        transform.LookAt(player);
    }

    private void Update()
    {
        if (distance <= desiredDistance && cameraReset)
        {
            distance += 0.01f;
            return;
        }
    }
}


