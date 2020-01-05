using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimalController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float max_speed = 10.0f;
    private float speed = 0.0f;
    private float dir = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.rotation = dir;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = 0.0f;
        float moveVertical = 0.0f;
        if (Input.GetKey(KeyCode.UpArrow) && speed < max_speed)
        {
            speed += 0.05f;
        }
        else
        {
            speed = 0.0f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir += 5.0f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            dir -= 5.0f;
        }

        moveHorizontal = Mathf.Sin(dir * Mathf.Deg2Rad) * speed * -1f;
        moveVertical = Mathf.Cos(dir * Mathf.Deg2Rad) * speed;

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.velocity = movement * speed;
        rb2d.rotation = dir;
    }
}
