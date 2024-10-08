using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float zEnemySpawn = 13.0f;
    private float xSpawn = 13.0f;
    private float ySpawn = 0.75f;
    private float zTopBound = 10.0f;
    private float zBottomBound = -3.0f;

    private float startTime = 1.0f;
    private float enemySpawnTime = 2.0f;
    private float powerupSpawnTime = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startTime, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startTime, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        float randomEnemyPosX = Random.Range(-xSpawn, xSpawn);
        int enemyIndex = Random.Range(0, enemies.Length);

        Vector3 enemyPos = new Vector3(randomEnemyPosX, ySpawn, zEnemySpawn);

        Instantiate(enemies[enemyIndex], enemyPos, enemies[enemyIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomPowerupPosX = Random.Range(-xSpawn, xSpawn);
        float randomPowerupPosZ = Random.Range(zBottomBound, zTopBound);

        Vector3 powerupPosition = new Vector3(randomPowerupPosX, ySpawn, randomPowerupPosZ);

        Instantiate(powerup, powerupPosition, powerup.gameObject.transform.rotation);
    }
}
