using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 2;
    public void Setup()
    {
        
    }
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
        //transform.Translate(transform.up * speed * Time.deltaTime);
    }
}
