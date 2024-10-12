using UnityEngine;
using System.Collections;
using Codice.Client.BaseCommands.CheckIn.Progress;

public class Enemy : MonoBehaviour
{

    float timer = 0;
    public GameObject HomingMisslePrefab;

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

        spawnMissleTimer();

    }


    public void spawnMissleTimer()
    {
        timer += Time.deltaTime;

        if (timer >= 10)
        {
            Instantiate(HomingMisslePrefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            print("Missle Spawned");
            timer = 0;

        }

    }





}
