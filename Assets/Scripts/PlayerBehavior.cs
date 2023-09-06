using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody2D rgbd = null;
    public float speed = 1f;
    public AudioClip coinSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CollectableItem")
        {
            AudioEngine.instance.PlaySound(coinSound);
            Destroy(collision.gameObject);
        }
    }

    [SerializeField][Range(0, 1)] float LerpConstant;
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(h, rgbd.velocity.y);
        rgbd.velocity = Vector2.Lerp(rgbd.velocity, movement, LerpConstant);
    }
}
