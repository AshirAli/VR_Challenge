using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;
    public static bool m_Paused = false;
    public GameObject pauseMenu;
    public GameObject coroutine;

    public void MenuOn()
    {
        pauseMenu.SetActive(true);
        m_TimeScaleRef = Time.timeScale;
        Time.timeScale = 0f;

        m_VolumeRef = AudioListener.volume;
        AudioListener.volume = 0f;

        m_Paused = true;

        StopCoroutine(coroutine.GetComponent<TimerScript>().StartTimer());
    }


    public void MenuOff()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = m_TimeScaleRef;
        AudioListener.volume = m_VolumeRef;
        m_Paused = false;
        StartCoroutine(coroutine.GetComponent<TimerScript>().StartTimer());
    }

    public void RestartGame()
    {
        Time.timeScale = m_TimeScaleRef;
        AudioListener.volume = m_VolumeRef;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        TimerScript.timeRemaining = 60;
        Health.health = 100;
        CoinTrigger.count = 0;
        CoinTrigger.i = 0;

    }

    public void LoadMenu()
    {
        Time.timeScale = m_TimeScaleRef;
        AudioListener.volume = m_VolumeRef;
        RestartGame();
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
