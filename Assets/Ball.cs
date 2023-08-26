using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float bounceForce = 10.0f; // Adjust the force as needed

    private Rigidbody rb;

    private void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Vector3 bounceDirection = Vector3.Reflect(rb.velocity.normalized, collision.contacts[0].normal);
            rb.AddForce(bounceDirection * bounceForce, ForceMode.Impulse);
        }
    }
}
