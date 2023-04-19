using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBounce : MonoBehaviour
{
    public Transform playerTrans;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall"))
        {
            playerTrans.localScale = new Vector3(playerTrans.localScale.x * -1, playerTrans.localScale.y, playerTrans.localScale.z);
        } 
    }
}
