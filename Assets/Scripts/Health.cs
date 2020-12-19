using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    Rigidbody2D rb;
    CellMovement cellMovement;

    public float stunLength = 2;
    float stunTime;
    public float knockback = 5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cellMovement = GetComponent<CellMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Damage(transform.position + new Vector3(0, 10), 0);
        }
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

    public void Damage(Vector3 hitFrom, float damage)
    {
        stunTime = stunLength;
        cellMovement.enabled = false;
        rb.AddForce(hitFrom * knockback);
    }
}
