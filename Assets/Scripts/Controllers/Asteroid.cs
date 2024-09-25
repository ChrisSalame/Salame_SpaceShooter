using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed;
    public float arrivalDistance;
    public float maxFloatDistance;
    Vector3 randMovementPace;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RandomDestination();
        AsteroidMovement();
    }

    public void AsteroidMovement()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, transform.position + randMovementPace, moveSpeed );

        if (Vector3.Distance (transform.position , transform.position + randMovementPace) < arrivalDistance)
        {
            randMovementPace = new Vector3(Random.Range(-1, maxFloatDistance), Random.Range(-1, maxFloatDistance));
        }
    }
    void RandomDestination ()
    {
        randMovementPace = new Vector3(Random.Range(-2, maxFloatDistance), Random.Range(-2, maxFloatDistance));
    }


}
