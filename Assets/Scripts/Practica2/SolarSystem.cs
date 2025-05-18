using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    //Public Attributes
    public Transform centerTransform;
    public Transform sunTransform;
    public float speedRotation;
    public float speedRotationSun;

    //Private Attributes
    private float rotationAngle = 30;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Look At
        transform.LookAt(centerTransform);
        



        //Rotate Around
        sunTransform.RotateAround(centerTransform.position, Vector3.up, rotationAngle * Time.deltaTime * speedRotationSun);

     
        
    }
}
