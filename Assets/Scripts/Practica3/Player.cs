using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Public Attributes
    public float moveSpeed = 5f;
    public Transform cameraTransform;
    public float rotationSpeed = 5f;
    public Transform playerTransform;
    public float speed = 5;

 
    
    
    

    void Update()
    {
        playerTransform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * speed);
        playerTransform.Translate(Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime * speed);
       


        //Camera
        cameraTransform.RotateAround(transform.position, Vector3.up, Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed);




    }

    




}
