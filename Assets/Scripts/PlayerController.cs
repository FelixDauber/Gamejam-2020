using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 pos = new Vector3(200, 200, 0);
    CellMovement cellMovement;

    private void Start()
    {
        cellMovement = GetComponent<CellMovement>();
    }

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        cellMovement.targetPoint = hit.point;
    }
}
