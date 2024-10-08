using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    public float accuracy = 0.01f;

    private void Update()
    {
        var direction = goal.position - transform.position;
        if (direction.magnitude < accuracy) return;
        
        transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
        transform.LookAt(goal);
    }
}
