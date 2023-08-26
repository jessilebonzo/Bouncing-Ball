using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bouncecount : MonoBehaviour
{
 public float bounceCooldown = 0.5f; // Cooldown time between bounces

    private float lastBounceTime;
    private int bounceCount = 0;
    private Rigidbody rb;

    public Text bounceCountText;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        lastBounceTime = Time.time;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") && (Time.time - lastBounceTime) > bounceCooldown)
        {
            bounceCount++;
            Debug.Log("Bounce Count: " + bounceCount);
            lastBounceTime = Time.time;

            // Update the UI text
            UpdateBounceCountText();
        }
    }
    private void UpdateBounceCountText()
    {
        if (bounceCountText != null)
        {
            bounceCountText.text = "Bounce Count: " + bounceCount;
        }
    }
}