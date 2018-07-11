using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuel : MonoBehaviour
{
    public GameObject fuelOff;
    public Text Noti;
    public GameObject fuelOn1;
    public GameObject fuelOn2;

    void OnTriggerEnter(Collider col)
    {
        if (col.name.StartsWith("Collider"))
        {
            fuelOff.SetActive(false);
            if (!fuelOn1.activeInHierarchy)
            {
                fuelOn1.SetActive(true);

            }
            if (!fuelOn2.activeInHierarchy)
            {
                fuelOn2.SetActive(true);

            }
            TimerScript.timeRemaining += 10;
            Noti.gameObject.SetActive(true);
            Invoke("Hide", 1);
        }
    }

    void Hide()
    {
        Noti.gameObject.SetActive(false);
    }

}