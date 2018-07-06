using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public GameObject timerText;
    private TimerScript timerScript;
    public GameObject fuel;

    void Awake()
    {
        timerScript = timerText.GetComponent<TimerScript>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.name.StartsWith("Collider"))
        {
            fuel.SetActive(false);
            timerScript.timeRemaining += 30;
        }
    }
}
//Just Destroying fuel on collision not respawning after some time.
