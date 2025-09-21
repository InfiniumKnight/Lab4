using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    private Transform player;
    private GameObject player2;
    [SerializeField] private float radius = 5f;
    private float speed;
    private float angle = 0f;
    private Vector3 point1;
    private Vector3 point2;
    private float x;
    private float z;

    void Start()
    { 
        player2 = GameObject.FindGameObjectWithTag("Player");
        player = player2.transform;
    }

    void Update()
    {
        point1 = player.position;
        point2 = transform.position;
        radius = (point1 - point2).magnitude;

        speed = radius * 2f;
        angle += speed * Time.deltaTime;

        float angleRad = angle * (Mathf.PI * 2) / 360;

        // Calculate the new position relative to the center object
        x = Mathf.Cos(angleRad) * radius;
        z = Mathf.Sin(angleRad) * radius;

        if (radius < 2f)
        {
            transform.position = point1 + new Vector3(x, z, 0) + new Vector3(0.1f, 0.1f, 0);
        }
        else
        {
            transform.position = point1 + new Vector3(x, z, 0);
        }

        Vector2 direction = player.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
    }
}
