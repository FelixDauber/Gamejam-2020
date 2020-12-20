using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 2;

    private void Start()
    {
        Destroy(gameObject, 3);
    }
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
        //transform.Translate(transform.up * speed * Time.deltaTime);
    }
}
