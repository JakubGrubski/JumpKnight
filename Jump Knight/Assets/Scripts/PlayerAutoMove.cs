using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAutoMove : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;

    public bool isGrounded;

    public Rigidbody2D rigid2d;

    [SerializeField] Transform groundCheck;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundMask;

    void FixedUpdate()
    {
        Move();
        Jump();

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundMask);
    }

    private void Move()
    {
        rigid2d.velocity = new Vector2(moveSpeed * Time.deltaTime, rigid2d.velocity.y);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rigid2d.AddForce(new Vector2(0, jumpHeight * Time.deltaTime), ForceMode2D.Impulse);
            }
        }
    }
}
