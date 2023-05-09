using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAutoMove : MonoBehaviour
{
    [Header("Movement Variables")]
    public float moveSpeed;
    public float jumpHeight;
    public Rigidbody2D rigid2d;

    [Header("Booleans")]
    public bool stopMotion;
    public bool isEnemy;

    [Header("Ground Check Variables")]
    public bool isGrounded;
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundMask;


    void FixedUpdate()
    {
        Move();
        CheckInput();
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundMask);
    }

    public void CheckInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    public void Move()
    {
        if (stopMotion)
            return;

        rigid2d.velocity = new Vector2(moveSpeed * Time.deltaTime, rigid2d.velocity.y);

        if (transform.localScale.x < -0.5)
        {
            rigid2d.velocity = new Vector2(moveSpeed * -1 * Time.deltaTime, rigid2d.velocity.y);
        }
    }

    private void Jump()
    {
        if (isEnemy)
            return;

        if (isGrounded)
        {
          rigid2d.AddForce(new Vector2(0, jumpHeight * Time.deltaTime), ForceMode2D.Impulse);
        }
        
    }

    public void StopMotion()
    {
        stopMotion = true;
        rigid2d.velocity = new Vector2(0,0);
    }
}
