using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBounce : MonoBehaviour
{
    public Transform bounceTransform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            bounceTransform.localScale = new Vector3(bounceTransform.localScale.x * -1, bounceTransform.localScale.y, bounceTransform.localScale.z);
        } 
    }
}
