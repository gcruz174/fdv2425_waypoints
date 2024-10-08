using UnityEngine;

public class Ejercicio6B : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    private void Update()
    {
        var direction = (goal.position - transform.position).normalized;
        transform.LookAt(goal);
        transform.Translate(direction * (Time.deltaTime * speed));
    }
}
