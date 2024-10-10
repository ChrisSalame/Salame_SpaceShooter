using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform targetTransform;
    public float angularSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 currentFacingDirection = transform.up;
        float facingAngle = Mathf.Atan2(currentFacingDirection.y, currentFacingDirection.x) * Mathf.Rad2Deg;

        Vector3 targetDirection = targetTransform.position - transform.position;
        float targetAngle = Mathf.Atan2(currentFacingDirection.y, currentFacingDirection.x) * Mathf.Rad2Deg;

        float deltaAngle = Mathf.DeltaAngle(facingAngle, targetAngle);

        //Debug.Log(deltaAngle);
        Debug.DrawLine(transform.position, transform.position + transform.up, Color.red);
        Debug.DrawLine(transform.position, targetDirection + transform.position, Color.blue);

        if (deltaAngle > 0)
        {
            transform.Rotate(0f, 0f, -angularSpeed * Time.deltaTime);
        }
        else if (deltaAngle < 0)
        {
            transform.Rotate(0f, 0f, angularSpeed * Time.deltaTime);
        }

    }
}
