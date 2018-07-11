using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
    public static int timeRemaining = 60;
    public GameObject overMenu;
    public GameObject GameUI;

    private float m_TimeScaleRef = 1f;
    private float m_VolumeRef = 1f;

    void Start()
    {

        timerText = GetComponent<Text>();
        StartCoroutine(StartTimer());

    }


    public IEnumerator StartTimer()
    {
        int temp, min, sec;
        while (true)
        {
            temp = timeRemaining;
            min = 0; sec = 0;
            while (temp >= 0)
            {
                if (temp >= 60)
                {
                    min += 1;
                    temp -= 60;
                }
                else
                {
                    sec = temp;
                    temp -= 60;
                }
            }
            if (!PauseMenu.m_Paused)
            {
                yield return null;
            }
            timerText.text = min.ToString("D2") + ":" + sec.ToString("D2");
            yield return new WaitForSeconds(1);
            timeRemaining--;

            if (timeRemaining <= 0)
            {
                Debug.Log("Timer Stopped.");
                StopCoroutine(StartTimer());
                LoadGameOverMenu();
            }
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