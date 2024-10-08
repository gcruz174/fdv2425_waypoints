using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public Vector3 goal;
    public float speed = 0.1f;

    private void Update()
    {
        transform.Translate(goal.normalized * (speed * Time.deltaTime));
    }
}
