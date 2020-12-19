using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellMovement : MonoBehaviour
{
    public Vector2 targetPoint;
    private Rigidbody2D rb;
    public float acceleration = 10;
    public float maxSpeed = 3;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveToTarget();
        //rb.velocity = (targetPoint - transform.position).normalized * speed;
        //rb.AddForce(targetPoint - new Vector2(transform.position.x, transform.position.y).normalized * speed);
            //rb.velocity = Vector2.zero;
        //}
        //else
        //{
        //    MoveToTarget();
        //}
    }
    void MoveToTarget()
    {
        //rb.AddForce((targetPoint - new Vector2(transform.position.x, transform.position.y)).normalized * acceleration * Time.deltaTime);

        rb.velocity = (targetPoint - new Vector2(transform.position.x, transform.position.y)) * acceleration; 

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}
