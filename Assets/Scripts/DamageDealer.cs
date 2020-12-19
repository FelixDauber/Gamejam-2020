using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public float damage = 10;
    public float damageCooldown = 1;
    public float damageTime;
    private void OnCollisionStay(Collision collision)
    {
        if(damageTime <= 0)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            if(health == null)
            {
                health = collision.gameObject.GetComponent<Health>();
            }
            if(health != null)
            {
                health.Damage(transform.position, damage);
            }
        }
        else
        {
            damageTime -= Time.deltaTime;
        }
    }
}
