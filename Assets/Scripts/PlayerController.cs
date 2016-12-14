using UnityEngine;
using System.Collections;

public class PlyerController : MonoBehaviour
{
    // Create object reference variable
    private Rigidbody rb;

    void Start()
    {
        // gets the rigidbody component
        rb.GetComponent<Rigidbody>();
    }

	// Use this for update
	void FixedUpdate()
	{
        // Horizontal and Vertical Inputs from Player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement);

	}
}
