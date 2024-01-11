using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody rb;
    public Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Getting player input
        Vector3 forward = cam.transform.forward;
        Vector3 right = cam.transform.right;
        forward.y = 0;
        forward = forward.normalized;
        right.y = 0;
        right = right.normalized;

        // Getting camera-normalized directional vectors
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Creating direction-relative input vectors
        Vector3 forwardRelativeVerticalInput = verticalInput * forward;
        Vector3 rightRelativeVerticalInput = horizontalInput * right;

        Vector3 cameraRelativeMovement = forwardRelativeVerticalInput + rightRelativeVerticalInput;
        rb.MovePosition(transform.position + cameraRelativeMovement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide");
    }
}
