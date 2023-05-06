using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;


    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
    {
    Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(touchPos.x <0)
        {
            rb.AddForce(Vector2.left * moveSpeed);
        }
        else{
            rb.AddForce(Vector2.right *moveSpeed);
        }

    }       
    else
    {
        rb.velocity = Vector2.zero;
    }




 }
}