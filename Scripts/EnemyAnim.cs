using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim: MonoBehaviour {

    public GameObject Enemy;
    public string AnimationName;

    void OnTriggerEnter(Collider other)
    {
        Enemy.GetComponent<Animator>().Play(AnimationName);
    }
}
