using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody2D rb2d = null;
    public GameManager gameManager;
    public float moveSpeed = 5f;
    public float jumpPower = 10f;
    public bool isGrounded = false;
 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("PlatformAnimated") || collision.gameObject.CompareTag("PlatformAnimated2") || collision.gameObject.CompareTag("PlatformAnimated3") || collision.gameObject.CompareTag("PlatformAnimated4") || collision.gameObject.CompareTag("PlatformAnimated5"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("Triangle"))
        {
            gameManager.GameOver();
        }
        if (collision.gameObject.CompareTag("Dot"))
        {
            gameManager.dotFalling.simulated = true;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("GameOverCollider"))
        {
            gameManager.GameOver();
        }
        if (collision.gameObject.CompareTag("Win"))
        {
            gameManager.isPlaying = false;
            gameManager.Win();
        }
    }

    void Update()
    {
        Vector3 Move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += Move * Time.deltaTime * moveSpeed;
        Jump();
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            rb2d.AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
            isGrounded = false;
        }
    }
}
