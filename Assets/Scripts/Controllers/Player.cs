using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

    private Vector3 VelocityOne = Vector3.zero;
    private Vector3 VelocityTwo = Vector3.zero;

    private float acceleration;

    private float timeToReachSpeed = 3f;
    private float targetSpeed = 2f;

    private void Start()
    {
        acceleration = targetSpeed / timeToReachSpeed;
    }
    void Update()
    {
        PlayerMovement();
        if (targetSpeed > 2)
        {
            targetSpeed = 2;
        }
    }


    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            VelocityOne += acceleration * transform.up * Time.deltaTime;
            transform.position += VelocityOne * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            VelocityTwo += acceleration * transform.right * Time.deltaTime;
            transform.position += VelocityTwo * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            VelocityOne += acceleration * transform.up * Time.deltaTime;
            transform.position -= VelocityOne * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            VelocityTwo += acceleration * transform.right * Time.deltaTime;
            transform.position -= VelocityTwo * Time.deltaTime;
        }




        else
        {
            targetSpeed -= acceleration;
        }


    }


}
