using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public float damage = 40;
    public float damageCooldown = 1;
    public float damageTime;
    public float knockback = 700;
    public bool destroyUponImpact = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (damageTime <= 0)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.Damage(transform.position, knockback, damage);
            }
        }
        else
        {
            damageTime -= Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (damageTime <= 0 && !collider.CompareTag(tag))
        {
            Health health = collider.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.Damage(transform.position, knockback, damage);
                if (destroyUponImpact)
                {
                    Destroy(gameObject);
                }
            }
        }
        else
        {
            damageTime -= Time.deltaTime;
        }
    }
}