using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float mouseSensX;
    public float mouseSensY;
    private float xMRotation;
    private float yMRotation;

    public float speedIncrease = 0.1f;
    public float maxSpeed = 200f;
    private float speed;

    Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
    }

    // Update is called once per frame
    void Update()
    {

        //Step 1: Get Mouse Input
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensY;

        yMRotation += mouseX;
        xMRotation -= mouseY;
        xMRotation = Mathf.Clamp(xMRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xMRotation, yMRotation, 0);


        //Step 2: Change Speed
        if (Input.GetKey(KeyCode.W))
        {
            speed += speedIncrease;
        } else if (Input.GetKey(KeyCode.S)){
            speed -= speedIncrease;
        }
        speed = Mathf.Clamp(speed, 0f, 100f);
        rb.AddForce(transform.forward * maxSpeed * speed);

    }
}
