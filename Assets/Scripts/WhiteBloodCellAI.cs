using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBloodCellAI : MonoBehaviour
{
    CellMovement cellMovement;
    public float engageRange = 3;
    public float wanderRange = 15;

    private void Start()
    {
        cellMovement = GetComponent<CellMovement>();
        cellMovement.targetPoint = transform.position;
    }

    void Update()
    {
        if (PlayerController.playerController != null && Vector3.Distance(PlayerController.playerController.transform.position, transform.position) < engageRange)
        {
            //cellMovement.targetPoint = transform.position - PlayerController.playerController.transform.position;
            cellMovement.targetPoint = PlayerController.playerController.transform.position;
        }
        else if (Vector2.Distance(cellMovement.targetPoint, transform.position) < 0.3f)
        {
            cellMovement.targetPoint += new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)) * wanderRange;
        }
    }
}