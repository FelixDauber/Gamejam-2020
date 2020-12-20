using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 cameraOffset;
    public float speed;

    void FixedUpdate()
    {
        if(target != null)
            transform.position = Vector3.Lerp(transform.position, target.position + cameraOffset, speed * Time.deltaTime);
    }
}
