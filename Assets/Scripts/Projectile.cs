using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 2;

    private void Start()
    {
        Destroy(gameObject, 3);
        transform.Translate(transform.up * 0.5f, Space.World);
    }
    void Update()
    {
        //transform.Translate(transform.up * speed * Time.deltaTime);
        Move();
    }
    void Move()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, speed * Time.deltaTime);
        if (hit.collider != null)
        {
            gameObject.GetComponent<DamageDealer>().Damage(hit.collider.gameObject);
        }
        transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
    }
}
