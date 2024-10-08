using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;

    private void Start()
    {
        transform.LookAt(goal);
    }

    private void Update()
    {
        var direction = goal.position - transform.position;
        transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
        Debug.DrawRay(transform.position, direction, Color.red);
    }
}
