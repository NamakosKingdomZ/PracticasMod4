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
    public float speedRotationSatelite1;
    public float speedRotationSatelite2;
    public Transform satelite1Transform;
    public Transform satelite2Transform;
    public Transform cameraTransform;

    //Private Attributes
    private float rotationAngle = 30;
    private float satelite1Angle = 90;
    private float satelite2Angle = 45;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Look At
        sunTransform.LookAt(centerTransform);
        satelite2Transform.LookAt(satelite1Transform);
        cameraTransform.LookAt(sunTransform.position);

        //DrawLine
        Debug.DrawRay(sunTransform.position, centerTransform.position, Color.green);
        Debug.DrawRay(sunTransform.position, satelite1Transform.position, Color.red);
        Debug.DrawRay(sunTransform.position, satelite2Transform.position, Color.blue);
        Debug.DrawRay(satelite1Transform.position, satelite2Transform.position, Color.yellow);


        //Rotate Around
        sunTransform.RotateAround(centerTransform.position, Vector3.forward, rotationAngle * Time.deltaTime * speedRotationSun);
        satelite1Transform.RotateAround(sunTransform.position, Vector3.up, satelite1Angle * Time.deltaTime * speedRotationSatelite1);
        satelite2Transform.RotateAround(satelite1Transform.position, Vector3.right, satelite2Angle * Time.deltaTime * speedRotationSatelite2);

     
        
    }
}
