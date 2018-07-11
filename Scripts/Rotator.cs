using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    public float rotateSpeed=30f;
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime*rotateSpeed,Space.World);
    }
}