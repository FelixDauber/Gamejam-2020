using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    Rigidbody2D rb;
    CellMovement cellMovement;

    public float maxHealth = 100;
    float health;

    public float stunLength = 2;
    float stunTime;
    public float knockback = 700;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cellMovement = GetComponent<CellMovement>();
        health = maxHealth;
    }

    private void Update()
    {
        if (stunTime > 0)
        {
            stunTime -= Time.deltaTime;
            if (stunTime <= 0)
            {
                stunTime = 0;
                cellMovement.enabled = true;
            }
        }
    }

    public void Damage(Vector3 hitFrom, float knockback, float damage)
    {
        stunTime = stunLength;
        cellMovement.enabled = false;
        rb.AddForce((transform.position - hitFrom) * knockback);
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
