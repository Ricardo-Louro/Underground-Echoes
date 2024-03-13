using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 moveDirection;
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();  
        moveDirection = Vector3.zero; 
    }

    private void Update()
    {
        SetMovementDirection();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void SetMovementDirection()
    {
        moveDirection = Input.GetAxis("Vertical") * transform.forward +
                        Input.GetAxis("Horizontal") * transform.right;

        moveDirection = moveDirection.normalized;
    }

    private void Move()
    {
        moveDirection.y = rb.velocity.y;
        rb.velocity = moveDirection * (moveSpeed * Time.fixedDeltaTime);
    }
}