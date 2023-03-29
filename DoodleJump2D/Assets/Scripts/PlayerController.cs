using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float Force;
    private Rigidbody2D rb;
    private bool lookRight = true;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && lookRight)
        {
            spriteRenderer.flipX = true;
            lookRight = false;
        }
        if (Input.GetKeyDown(KeyCode.D) && !lookRight)
        {
            spriteRenderer.flipX = false;
            lookRight = true;
        }
    }
    private void FixedUpdate()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalMove * speed * Time.deltaTime,rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            rb.AddForce(transform.up * Force);
        }
    }
}
