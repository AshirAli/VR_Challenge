using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public Text timerText;
    public int timeRemaining = 60;

    void Start()
    {

        timerText = GetComponent<Text>();
        StartCoroutine(StartTimer());

    }


    public IEnumerator StartTimer()
    {
        Debug.Log("Started");
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
            timerText.text = min.ToString("D2") + ":" + sec.ToString("D2");
            yield return new WaitForSeconds(1);
            timeRemaining--;

            if (timeRemaining <= 0)
            {

                Debug.Log("Timer Stopped.");
                StopCoroutine(StartTimer());
                //SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);

            }
        }
    }
}
