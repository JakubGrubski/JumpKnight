using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAutoMove : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rigid2d;
   

    void Start()
    {
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        rigid2d.velocity = new Vector2(moveSpeed * Time.deltaTime, rigid2d.velocity.y);
    }
}
