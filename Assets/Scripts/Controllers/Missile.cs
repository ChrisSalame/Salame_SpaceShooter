using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 missilePosition = new Vector3(transform.position.x, transform.position.y + 1 * Time.deltaTime);
        transform.position = missilePosition;
    }

}
