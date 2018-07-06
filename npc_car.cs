using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{


    public float speed = 10f;
    public GameObject Enemy;

    void OnTriggerEnter(Collider other)
    {
        Enemy.transform.Translate(speed,0,0);
    }
}
