using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Debug.Log("Start functýon in playermovement script.");

        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveZ, 0);

        rb.AddForce(movement * speed);


    }

















}
