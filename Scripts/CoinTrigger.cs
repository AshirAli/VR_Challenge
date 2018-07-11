using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTrigger : MonoBehaviour {

    public Transform[] Spawnpoint;
    public GameObject Prefab;
    public GameObject CoinEffect;
    public static int i = 0;

    public Text CountText;
    public static int count = 0;

    void OnTriggerEnter()
    {
        count += 1;
        CountText.text = count.ToString();

        Instantiate(Prefab, Spawnpoint[i].position, Spawnpoint[i].rotation);

        CoinEffect.SetActive(true);
        Destroy(gameObject);

        i += 1;
        if (i == 10)
        {
            i = 0;
        }
    }
}
