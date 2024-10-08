using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public Transform goal;
    public float rotateSpeed = 1.0f;
    public float speed = 1.0f;

    private void Update()
    {
        var direction = goal.position - transform.position;
        var targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * (Time.deltaTime * speed));
    }
}
