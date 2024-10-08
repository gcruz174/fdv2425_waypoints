using UnityEngine;

public class Ejercicio6A : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    private void Update()
    {
        transform.LookAt(goal);
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}
