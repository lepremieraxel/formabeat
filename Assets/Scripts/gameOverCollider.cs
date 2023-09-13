using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverCollider : GameManager
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameOver();
        }
    }
}
