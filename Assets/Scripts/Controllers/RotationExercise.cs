using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationExercise : MonoBehaviour
{
    public Transform targetToRotateTo;
    public float AngularSpeed;

    Vector3 newTarget;

    void Start()
    {
        
    }



    void Update()
    {
        Vector3 startPosition = transform.position;
        //Debug.DrawLine(startPosition, , Color.red);


    }
}
