using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    public float sensitivity;
    public float speed;

    // public Transform orientation;

    // float xRotation;
    // float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;
        // Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        // // Move the camera forward, backward, left, and right
        // transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        // transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        // Rotate the camera based on the mouse movement
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        mouseX = Mathf.Clamp(mouseX, -90f, 90f);
        transform.eulerAngles += new Vector3(-mouseY * sensitivity, mouseX * sensitivity, 0);
        // if (transform.rotation.x < -90f)
        // {
        //     transform.rotation.x = -90f;
        // }
        // if (transform.rotation.x > 90f)
        // {
        //     transform.rotation.x = 90f;
        // }
    }
}
