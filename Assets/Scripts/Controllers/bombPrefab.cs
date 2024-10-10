using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombPrefab : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Destroy(this.gameObject);

            print("bomb destroyed");
        }
    }
}
