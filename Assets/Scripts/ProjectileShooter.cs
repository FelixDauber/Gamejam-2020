using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public float cooldown;
    public GameObject projectilePrefab;
    public float currentCooldown;
    void Update()
    {
        currentCooldown -= Time.deltaTime;
        if(currentCooldown <= 0)
        {
            Fire();
            currentCooldown += cooldown;
        }
    }

    void Fire()
    {
        GameObject newProjectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        newProjectile.tag = tag;
    }
}
