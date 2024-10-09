using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProduct : MonoBehaviour
{
    public float redAngle;
    public float blueAngle;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 redVector = new Vector3(Mathf.Cos(redAngle * Mathf.Deg2Rad), Mathf.Sin(redAngle * Mathf.Deg2Rad));
        Vector3 blueVector = new Vector3(Mathf.Cos(blueAngle * Mathf.Deg2Rad), Mathf.Sin(blueAngle * Mathf.Deg2Rad));

        Debug.DrawLine(Vector3.zero, redVector, Color.red);
        Debug.DrawLine(Vector3.zero, blueVector, Color.blue);

        float dotRB = redVector.x * blueVector.x * redVector.y * blueVector.y;

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Debug.Log(dotRB.ToString());
        }

        //Vector2 redAngleSides = new Vector2(Mathf.Cos(redAngle) * Mathf.Deg2Rad, Mathf.Sin(redAngle) * Mathf.Deg2Rad);
        //Debug.DrawLine(origin,redAngleSides);
        //print(redAngleSides.x);
        //print(redAngleSides.y);
    }
}
