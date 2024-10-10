using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;
    public GameObject PowerUpPrefab;

    private Vector3 VelocityOne = Vector3.zero;
    private Vector3 VelocityTwo = Vector3.zero;

    private float acceleration;

    private float timeToReachSpeed = 3f;
    private float targetSpeed = 2f;

    int circlePointIndex = 0;

    public int numberOfSides;
    Color radarColor = Color.green;

    public int powerUpCount;

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

        EnemyRadar(1,numberOfSides);
        SpawnPowerups(1,powerUpCount);
        spawnBomb();
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

    public void EnemyRadar(float radius, int circlePoints)
    {

        float currentPoint = 360 / circlePoints;
        List<float> points = new List<float>();

        for (int index = 0; index <= circlePoints; index++) 
        {
            points.Add(currentPoint * index);

            for (int numberOfPoints = 1; numberOfPoints < points.Count; numberOfPoints ++) 
            {
               
                Vector3 startPoint = transform.position + new Vector3(Mathf.Cos(points[numberOfPoints - 1] * Mathf.Deg2Rad * radius), Mathf.Sin(points[numberOfPoints - 1] * Mathf.Deg2Rad * radius));
                Vector3 endPoint = transform.position + new Vector3(Mathf.Cos(points[numberOfPoints ] * Mathf.Deg2Rad * radius), Mathf.Sin(points[numberOfPoints] * Mathf.Deg2Rad * radius));

                Debug.DrawLine(startPoint, endPoint, radarColor);
            }
        }
                if (Vector3.Distance(transform.position, enemyTransform.position) <= radius)

                {
                     radarColor = Color.red;
                }
                else 
                {
                    radarColor = Color.green;
                }



    }



    public void spawnBomb() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(bombPrefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);

            print("space was pressed");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            //Destroy(this.gameObject);

            print("bomb destroyed");
        }


    }


    public void SpawnPowerups(float radius, int numberOfPowerups) 
    {
        float powerUpArea = 360 / numberOfPowerups;

        List<float> amountOfPU = new List<float>();

        for (int index = 0; index <= numberOfPowerups; index++)
        {
            amountOfPU.Add(powerUpArea * index);

            for (int numPU = 1; numPU < amountOfPU.Count; numPU++)
            {

                Vector3 PUpointX = transform.position + new Vector3(Mathf.Cos(amountOfPU[numPU - 1] * Mathf.Deg2Rad * radius), Mathf.Sin(amountOfPU[numPU - 1] * Mathf.Deg2Rad * radius));

                if (Input.GetKeyDown("p"))
                {
                    Instantiate(PowerUpPrefab, PUpointX, Quaternion.identity);

                }

            }
        }
    
    }



}

