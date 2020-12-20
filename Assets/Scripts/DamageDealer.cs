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
        Damage(collision.collider.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        Damage(collider.gameObject);
    }
    public void Update()
    {
        if(damageTime > 0)
        {
            damageTime -= Time.deltaTime;
        }
    }
    public void Damage(GameObject target)
    {
        if (damageTime <= 0)// && !target.CompareTag(tag))
        {
            Health health = target.GetComponent<Health>();
            if (health != null)
            {
                health.Damage(transform.position, knockback, damage);
                if (destroyUponImpact)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}