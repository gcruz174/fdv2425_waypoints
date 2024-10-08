using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public Vector3 goal;

    private void Start()
    {
        transform.Translate(goal);
    }
}
