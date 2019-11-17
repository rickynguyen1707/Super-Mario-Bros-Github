using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{
    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;
    public float speed = 10.0f;
    public float boundX = 2.5f;
    private Rigidbody2D rb2d;
    public int xVel = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        if (Input.GetKey(moveRight))
        {
            vel.x = speed + xVel;
        }
        else if (Input.GetKey(moveLeft))
        {            
            vel.x = -speed - xVel;   
        }
        else
        {
            vel.x = 0;
        }
        rb2d.velocity = vel;
        var pos = transform.position;
        if (pos.x > boundX)
        {
            pos.x = boundX;
        }
        else if (pos.x < (boundX-21))
        {
            pos.x = 0;
        }
        transform.position = pos;
    }
}
