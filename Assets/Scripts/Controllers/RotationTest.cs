using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RotationTest : MonoBehaviour
{

    public float AngularSpeed;
    public float TargetAngle;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = transform.position + transform.up;
        Debug.DrawLine(startPosition,endPosition, Color.red);

        if (transform.eulerAngles.z != TargetAngle)
        {
            transform.Rotate(0, 0, AngularSpeed * Time.deltaTime);
        }


        if (transform.eulerAngles.z > TargetAngle)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, TargetAngle);
        }

        //if (transform.rotation.z == TargetAngle)
        //{
        //    print("complete at angle");
        //}
        //else 
        //{
        //    transform.RotateAround(transform.position, Vector3.forward, AngularSpeed * Time.deltaTime);
        //}

        //Debug.DrawLine(transform.position, Vector3.up, Color.red);

    }

    public float StandardizeAngle(float inAngle)
    {
        inAngle = inAngle % 360;
        inAngle = (inAngle + 360) % 360;

        if (inAngle >180)
        {
            inAngle -= 360;
        }
        return inAngle;
    }

}
