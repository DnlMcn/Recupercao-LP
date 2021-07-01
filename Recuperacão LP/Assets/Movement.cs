using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float accelCoeff;
    float currentSpeed;
    float deltaPosition;
    float accelerationForce;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");

        currentSpeed = transform.position.x - deltaPosition;
        bool isForward = currentSpeed >= 0 ? true : false;

        accelerationForce = Mathf.Lerp(accelCoeff, 1, Mathf.Clamp01(currentSpeed));

        if (v > 0) 
        {
            if (isForward) {rb.AddForce(new Vector3(v * accelerationForce, 0, 0), ForceMode.Force);}
            else {rb.AddForce(new Vector3(v * accelerationForce * 2, 0, 0), ForceMode.Force);}
        }

        if (v < 0) 
        {
            if (!isForward) {rb.AddForce(new Vector3(v * accelerationForce, 0, 0), ForceMode.Force);}
            else {rb.AddForce(new Vector3(v * accelerationForce * 2, 0, 0), ForceMode.Force);}
        }

        deltaPosition = transform.position.x;

    }
}

