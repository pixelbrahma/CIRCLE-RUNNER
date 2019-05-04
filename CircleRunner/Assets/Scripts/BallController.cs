using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    [SerializeField] private float jumpForce;
    private Rigidbody myRigidBody;
    private bool isGrounded;

	void Start () {
        myRigidBody = GetComponent<Rigidbody>();
        isGrounded = true;
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            myRigidBody.AddForce(Vector3.up.normalized * jumpForce);
            isGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Base")
        {
            isGrounded = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BackGround")
        {
            Debug.Log("GAME OVER");
            Destroy(this.gameObject);
        }
    }
}
