using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 cameraOffset;
    public float speed;

    void Update()
    {
        if(target != null)
            transform.position = Vector3.Lerp(target.position, transform.position, speed * Time.deltaTime) + cameraOffset;
    }
}
