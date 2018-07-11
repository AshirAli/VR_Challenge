using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health: MonoBehaviour
{

    public static float health = 100;
    public Image healthBar;
    public int damage;

    public AudioClip CoinAudio;

    public GameObject overMenu;
    public GameObject GameUI;

    private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collider")
        {
            TakeDamage(damage);
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            GetComponent<AudioSource>().PlayOneShot(CoinAudio);
        }
    }


    public void TakeDamage(int amount)
    {
        health -= amount;

        healthBar.fillAmount = health / 100f;

        if (health <= 0)
        {
            LoadGameOverMenu();
        }

    }
    void LoadGameOverMenu()
    {
        overMenu.SetActive(true);
        PauseMenu.m_Paused = true;
        GameUI.SetActive(false);

        m_TimeScaleRef = Time.timeScale;
        Time.timeScale = 0f;
        m_VolumeRef = AudioListener.volume;
        AudioListener.volume = 0f;
    }
}
