using UnityEngine;
using System.Collections;

public class Objects : MonoBehaviour {
    
    void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent();
        if (health  != null)
        {
            health.TakeDamage(10);
        }

        Destroy(gameObject);
    }
}