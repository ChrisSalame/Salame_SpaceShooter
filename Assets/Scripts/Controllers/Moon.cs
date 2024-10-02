using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform planetTransform;

    public float radius;
    public float speed;


    void Update()
    {
        OrbitalMotion(radius,speed, planetTransform);
    }

    public void OrbitalMotion(float radius, float speed, Transform target) 
    {
        transform.RotateAround(target.transform.position, Vector3.forward, speed * Time.deltaTime);
    
    }
}
