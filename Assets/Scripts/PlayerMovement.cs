using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody rb;
    public Transform orientation;
    
    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        // horizontalInput = Input.GetAxisRaw("Horizontal");
        // verticalInput = Input.GetAxisRaw("Vertical");

        // if (Input.GetKeyDown(KeyCode.W))
        // {
        //     MovePlayer();
        // }

        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     Debug.Log("A");
        // }
        // if (Input.GetKeyDown(KeyCode.S))
        // {
        //     Debug.Log("S");
        // }

        // if (Input.GetKeyDown(KeyCode.D))
        // {
        //     Debug.Log("D");
        // }
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0 , Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody>().MovePosition(transform.position + direction * moveSpeed * Time.fixedDeltaTime);
    }

    void MovePlayer()
    {
        // Debug.Log("ok");
        // Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0 , Input.GetAxisRaw("Vertical"));
        // GetComponent<Rigidbody>().MovePosition(transform.position + direction * movementSpeed * Time.fixedDeltaTime);
    }
}
