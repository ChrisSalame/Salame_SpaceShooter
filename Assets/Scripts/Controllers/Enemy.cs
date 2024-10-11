using UnityEngine;
using System.Collections;
using Codice.Client.BaseCommands.CheckIn.Progress;

public class Enemy : MonoBehaviour
{

    public float speed;


    private void Update()
    {
        transform.position = new Vector2 (transform.position.x + speed, transform.position.y) ;
        if (transform.position.x >= 20) 
        {
            speed = -speed;
        }
        if (transform.position.x <= -20)
        {
            speed = -speed;
        }

    }





}
