using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 offsetDirection;
    float offsetMagnitude;

    void Start()
    {
        offsetMagnitude = Vector3.Distance(target.position, transform.position);

        offsetDirection = (transform.position - target.position).normalized;

    }

    void Update()
    {
        transform.position = target.position + offsetDirection * offsetMagnitude;

    }

}
