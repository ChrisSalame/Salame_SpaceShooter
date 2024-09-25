using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed;
    public float arrivalDistance;
    public float maxFloatDistance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AsteroidMovement();
    }

    public void AsteroidMovement()
    {
        Vector3 randMovementPace = new Vector3(Random.Range(-1, 2), Random.Range(-1, 2));

        transform.position = Vector3.MoveTowards(transform.position, transform.position + randMovementPace, moveSpeed);



    }



}
