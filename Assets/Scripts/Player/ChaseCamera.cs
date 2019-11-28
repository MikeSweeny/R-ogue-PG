using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    public GameObject target;
    public float distance = 12.0f;

    public float yMinLimit = -80f;
    public float yMaxLimit = 80.0f;
    public float autoRotSpeed = 3.0f;

    float xDeg = 0.0f;
    float yDeg = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        xDeg = angles.x;
        yDeg = angles.y;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        RotateBehindTarget();

        yDeg = ClampAngle(yDeg, yMinLimit, yMaxLimit);
        Quaternion rotation = Quaternion.Euler(yDeg, xDeg, 0);

        transform.rotation = rotation;
        transform.LookAt(target.transform);

    }

    // Keeps the camera behind the player
    private void RotateBehindTarget()
    {
        float targetRotationAngle = target.transform.eulerAngles.y;
        float currentRotationAngle = transform.eulerAngles.y;
        xDeg = Mathf.LerpAngle(currentRotationAngle, targetRotationAngle, autoRotSpeed * Time.deltaTime);
    }

    // Makes it so you cannot go over 90 degrees up and down
    float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360f)
            angle += 360f;

        if (angle > 360f)
            angle -= 360f;

        return Mathf.Clamp(angle, min, max);
    }
}