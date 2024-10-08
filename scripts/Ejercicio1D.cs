using UnityEngine;

public class Ejercicio1D : MonoBehaviour
{
    public Vector3 goal;
    public float maxHeight = 3f;

    private void Start()
    {
        transform.Translate(goal);
    }

    private void Update()
    {
        transform.Translate(goal);
        if (transform.position.y > maxHeight)
        {
            transform.position = new Vector3(transform.position.x, maxHeight, transform.position.z);
        }
    }
}
