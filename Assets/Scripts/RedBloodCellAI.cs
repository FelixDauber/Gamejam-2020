using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBloodCellAI : MonoBehaviour
{
    CellMovement cellMovement;
    public float escapeRange;

    private void Start()
    {
        cellMovement = GetComponent<CellMovement>();
    }

    void Update()
    {
        if(PlayerController.playerController != null && Vector3.Distance(PlayerController.playerController.transform.position, transform.position) < escapeRange)
        {
            cellMovement.targetPoint = transform.position - PlayerController.playerController.transform.position;
        }
    }
}
