using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour {

    public GameObject openFire;
    public bool IsActive = false;
    public float sec = 1f;
    void Start()
    {
        StartCoroutine(OpenFire(sec));
    }

    void StopFlames()
    {
        StopCoroutine("OpenFire");
        IsActive = false; 
        openFire.SetActive(false);
    }

    IEnumerator OpenFire(float waitTime)
    {
        IsActive = true; 
        while (true)
        {
            openFire.SetActive(true);
            yield return new WaitForSeconds(waitTime);
            openFire.SetActive(false);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
