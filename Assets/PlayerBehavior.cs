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

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            
        }
    }
}
