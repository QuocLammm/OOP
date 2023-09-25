using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    [SerializeField] public GameObject[] enemyPrefabs; //chứa quái
    [SerializeField] public float timeBetweenWaves = 5f; //thời gian giữa các wave
    [SerializeField] public int numberOfEnemies = 10;
    [SerializeField] public float timeBetweenEnemies = 0.5f;

    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(timeBetweenWaves);

        for (int i = 0; i < numberOfEnemies; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-70, 70),Random.Range(-70, 70),0);
            GameObject enemy = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)],
                spawnPos, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenEnemies);
        }
        Destroy(gameObject);
    }
}

