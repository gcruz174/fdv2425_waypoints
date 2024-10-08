using System;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public float speed = 5f;
    public float rotateSpeed = 5f;
    
    private List<Transform> _waypoints;
    private int _currentWaypointIndex;

    private void Start()
    {
        var waypointObjects = GameObject.FindGameObjectsWithTag("Waypoint");
        _waypoints = new List<Transform>();
        foreach (var waypoint in waypointObjects)
        {
            _waypoints.Add(waypoint.transform);
        }
        
        _waypoints.Sort((w1, w2) => string.Compare(w1.name, w2.name, StringComparison.Ordinal));
    }

    private void Update()
    {
        var targetWaypoint = _waypoints[_currentWaypointIndex];
        var direction = targetWaypoint.position - transform.position;
        transform.position += direction.normalized * (speed * Time.deltaTime);
        
        var targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Count;
        }
    }
}
