using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float accelCoeff;
    float currentSpeed;
    Vector3 deltaPosition;
    float accelerationForce;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        currentSpeed = Vector3.Distance(transform.position, deltaPosition);

        // accelerationForce = Mathf.Lerp(20, accelCoeff, Mathf.Clamp(currentSpeed, 1, .1f));

        accelerationForce = accelCoeff;

        rb.AddForce(new Vector3(h, 0, v) * accelerationForce * Time.deltaTime, ForceMode.Acceleration);

        deltaPosition = transform.position;

        // bool isForward = currentSpeed >= 0 ? true : false;

        // accelerationForce = Mathf.Lerp(accelCoeff, 1, Mathf.Clamp01(currentSpeed));

        // if (v > 0) 
        // {
        //     if (isForward) {rb.AddForce(new Vector3(v * accelerationForce, 0, 0), ForceMode.Force);}
        //     else {rb.AddForce(new Vector3(v * accelerationForce * 2, 0, 0), ForceMode.Force);}
        // }

        // if (v < 0) 
        // {
        //     if (!isForward) {rb.AddForce(new Vector3(v * accelerationForce, 0, 0), ForceMode.Force);}
        //     else {rb.AddForce(new Vector3(v * accelerationForce * 2, 0, 0), ForceMode.Force);}
        // }

        

    }
}

