using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    public GameObject center;
    public float angle;
    public float initianRotation;

    public float rotationSpeed = 0.5f;
    public float selfRotationSpeed = 0.5f;


    void Start()
    {
        double a = angle * Math.PI / 180;
        Vector3 rotationAxis = new Vector3((float)Math.Sin(a), (float)Math.Cos(a), 0);
        this.transform.RotateAround(center.transform.position, rotationAxis.normalized, initianRotation);
    }
    // Update is called once per frame
    void Update()
    {
        double a = angle * Math.PI / 180;
        Vector3 rotationAxis = new Vector3((float)Math.Sin(a), (float)Math.Cos(a), 0);
        this.transform.RotateAround(center.transform.position, rotationAxis.normalized, rotationSpeed);
        this.transform.Rotate(Vector3.up, -selfRotationSpeed); 
    }
}
