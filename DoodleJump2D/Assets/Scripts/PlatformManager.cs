using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{

    public float Force;
    private Vector2 playerMove;
    private Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb = collision.gameObject.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            playerMove = rb.velocity;
            playerMove.y = Force;
            rb.velocity = playerMove;
        }
    }
}
