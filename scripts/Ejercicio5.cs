using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public Transform goal;
    public float speed = 1.0f;
    public float speedIncrement = 1.0f;

    private void Update()
    {
        var direction = goal.position - transform.position;
        transform.Translate(direction.normalized * (Time.deltaTime * speed), Space.World);
        transform.LookAt(goal);
        
        if (Input.GetKeyDown(KeyCode.Space)) speed += speedIncrement;
    }
}
