using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody kiril;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
    [SerializeField] AudioSource jumpSound;



    void Start()
    {
        kiril = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        kiril.velocity = new Vector3(horizontalInput * movementSpeed, kiril.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded())

        {
            //kiril.velocity = new Vector3(kiril.velocity.x, jumpForce, kiril.velocity.z);
            Jump();
        }
    }
    void Jump()
    {
        kiril.velocity = new Vector3(kiril.velocity.x, jumpForce, kiril.velocity.z);
        jumpSound.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Head"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }
    bool IsGrounded() {

         return Physics.CheckSphere(groundCheck.position ,.1f, ground);
    }

}
