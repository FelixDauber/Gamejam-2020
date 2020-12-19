using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject whiteCell;
    [SerializeField] private GameObject redCell;
    [SerializeField] private Collider2D[] enemies;
    [SerializeField] private int checkRange;
    [SerializeField] private int maxEnemies;
    [SerializeField] private Transform[] spawnPos;
    private void Start(){
        InvokeRepeating("CheckForEnemies", 1f, 1f);
    }
    private void CheckForEnemies(){
        enemies = Physics2D.OverlapCircleAll(this.transform.position, this.checkRange, LayerMask.GetMask("Enemy"));
        if(enemies.Length <= maxEnemies){
            int whichEnemy = Random.Range(0, 2);
            SpawnEnemies(whichEnemy);
        }
    }
    private void SpawnEnemies(int whichEnemy){
        Transform currentSpawn = spawnPos[Random.Range(0, spawnPos.Length)];
        GameObject newSpawn;
        switch (whichEnemy)
        {
            case 1:
            //spawn white cell here
            newSpawn = Instantiate(whiteCell, currentSpawn);
            newSpawn.transform.parent = null;
            break;

            default:
            //spawn red cell here
            newSpawn = Instantiate(redCell, currentSpawn);
            newSpawn.transform.parent = null;
            break;
        }
    }
}
