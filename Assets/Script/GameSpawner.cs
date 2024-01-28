using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemysPrefbs;
    int randomSpawnPoint;
    int randomEnemy;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 1f);
    }

    void SpawnEnemy()
    {
        // get random spawn point
        randomSpawnPoint = Random.Range(0,spawnPoints.Length);

        //get random enemy
        randomEnemy=Random.Range(0,enemysPrefbs.Length);

        //spawn enemy randomly
        Instantiate(enemysPrefbs[randomEnemy],spawnPoints[randomSpawnPoint].position,Quaternion.identity);

    }
}
