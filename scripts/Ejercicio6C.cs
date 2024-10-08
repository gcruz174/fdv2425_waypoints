using UnityEngine;

public class Ejercicio6C : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    private void Update()
    {
        var direction = (goal.position - transform.position).normalized;
        transform.LookAt(goal);
        transform.Translate(direction * (Time.deltaTime * speed), Space.World);
    }
}
