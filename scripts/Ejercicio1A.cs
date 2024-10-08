using System;
using UnityEngine;

public class Ejercicio1A : MonoBehaviour
{
    public Vector3 goal;

    private void Start()
    {
        transform.Translate(goal);
    }

    private void Update()
    {
        transform.Translate(goal);
        goal *= 0.5f;
    }
}
