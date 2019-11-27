using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    public GameObject target;
    public float heightOffset = 1.7f;
    public float distance = 12.0f;

    public float offsetFromWall = 0.1f;
    public float maxDistance = 20f;
    public float minDistance = 0.6f;
    public float xSpeed = 200.0f;
    public float ySpeed = 200.9f;
    public float yMinLimit = -80f;
    public float yMaxLimit = 80.0f;
    public float autoRotSpeed = 3.0f;

    public LayerMask collisionLayers = -1;
    public bool alwaysRotToRearOfTarget = false;
    public bool allowMouseInputX = true;
    public bool allowMouseInputY = true;


    float xDeg = 0.0f;
    float yDeg = 0.0f;
    float currentDistance;
    float desiredDistance;
    bool rotBehind = false;
    bool mouseSideButton = false;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        xDeg = angles.x;
        yDeg = angles.y;
        currentDistance = distance;
        desiredDistance = distance;

        rotBehind = alwaysRotToRearOfTarget;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        RotateBehindTarget();

        yDeg = ClampAngle(yDeg, yMinLimit, yMaxLimit);

        Quaternion rotation = Quaternion.Euler(yDeg, xDeg, 0);

        desiredDistance = Mathf.Clamp(desiredDistance, minDistance, maxDistance);


        Vector3 vTargetOffset = new Vector3(0, -heightOffset, 0);
        Vector3 position = target.transform.position - (rotation * Vector3.forward * desiredDistance + vTargetOffset);

        Vector3 trueTargetPosition = new Vector3(target.transform.position.x, target.transform.position.y + heightOffset, target.transform.position.z);

        currentDistance = Mathf.Clamp(currentDistance, minDistance, maxDistance);

        position = target.transform.position - (rotation * Vector3.forward * currentDistance + vTargetOffset);

        transform.rotation = rotation;
        transform.position = position;

    }

    private void RotateBehindTarget()
    {
        float targetRotationAngle = target.transform.eulerAngles.y;
        float currentRotationAngle = transform.eulerAngles.y;
        xDeg = Mathf.LerpAngle(currentRotationAngle, targetRotationAngle, autoRotSpeed * Time.deltaTime);

        if (targetRotationAngle == currentRotationAngle)
        {
            if (!alwaysRotToRearOfTarget)
            {
                rotBehind = false;

            }
        }
        else
        {
            rotBehind = true;
        }
    }

    float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360f)
            angle += 360f;

        if (angle > 360f)
            angle -= 360f;

        return Mathf.Clamp(angle, min, max);
    }
}


