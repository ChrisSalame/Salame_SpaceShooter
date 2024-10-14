using UnityEngine;
using System.Collections;
using Codice.Client.BaseCommands.CheckIn.Progress;

public class Enemy : MonoBehaviour
{

    float timer = 0;
    public GameObject HomingMisslePrefab;
    public float speed;

    public GameObject player;

    private void Start()
    {

    }

    private void Update()
    {
        transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        if (transform.position.x >= 20)
        {
            speed = -speed;
        }
        if (transform.position.x <= -20)
        {
            speed = -speed;
        }
        spawnMissleTimer();
        rotate();

    }

    public void rotate()
    {
        Vector2 targetLookAt = player.transform.position - transform.position;
        targetLookAt.Normalize();
        float targetLookAtAngle = Mathf.Atan2(targetLookAt.y, targetLookAt.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(Vector3.forward * targetLookAtAngle);

    }


    public void spawnMissleTimer()
    {
        timer += Time.deltaTime;

        if (timer >= 5)
        {
            Instantiate(HomingMisslePrefab, transform.position, Quaternion.identity);
            print("Missle Spawned");
            timer = 0;

        }

    }
}
