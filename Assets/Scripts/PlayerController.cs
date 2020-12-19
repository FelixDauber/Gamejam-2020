using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CellMovement cellMovement;
    public static PlayerController playerController;

    private void Awake()
    {
        if(playerController == null)
        {
            playerController = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        cellMovement = GetComponent<CellMovement>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            Vector3 newVec = hit.point - transform.position;
            transform.up = new Vector3(newVec.x, newVec.y, 0);
            cellMovement.targetPoint = hit.point;
        }
    }
}
