using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChronoManager : MonoBehaviour
{
    [SerializeField] float timer;
    public Text chrono = null;
    public SpriteRenderer letterA = null;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        chrono.text = Math.Round(timer).ToString();
        if(Math.Round(timer) % 2 > 0)
        {
            letterA.color = Color.cyan;
        } else
        {
            letterA.color = Color.white;
        }
    }
}
