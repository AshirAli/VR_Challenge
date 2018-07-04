using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public float health = 100;
    public Image healthBar;
    public int damage;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collider")
        {
            TakeDamage(damage);
            Debug.Log("Taking Damage");
        }
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        healthBar.fillAmount = health / 100f;
        
        if (health <= 0){
            health = 0;
            Debug.Log("Dead!");
        }
    }
}
