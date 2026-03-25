using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class BallController : MonoBehaviour
{
    private CharacterController controller;

    public float moveSpeed = 5f;
    public float gravity = -20f;
    public float jumpForce = 10f;
    public float bounceMultiplier = 0.6f;

    private Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * moveSpeed * Time.deltaTime);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = jumpForce;
        }

        
        velocity.y += gravity * Time.deltaTime;

        
        CollisionFlags flags = controller.Move(velocity * Time.deltaTime);

        
        if ((flags & CollisionFlags.Below) != 0 && velocity.y < 0)
        {
            velocity.y = -velocity.y * bounceMultiplier;
        }
    }
}