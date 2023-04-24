using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int animalIndex;
    public float spawnRangeX = 25f;
    public float spawnRangeZ;
    [SerializeField, Range (2f,5f)]
    private float startDelay = 2.5f; //Tiempo inicial que tarda en invocar el método "SpawnEnemies()"
    [SerializeField, Range(0.1f, 2f)]
    private float spawnInterval = 0.5f; //Intervalo de tiempo (0,5 secs) que tarda entre cada llamada a "SpawnEnemies()"
    // Start is called before the first frame update

    private void Awake()
    {
        spawnRangeZ =transform.position.z;
    }

    void Start()
    {
        //Invocamos el método "SpawnEnemies()", cuando ha pasado startDelay y posteriormente cada spawnInterval
        InvokeRepeating("SpawnEnemies", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void SpawnEnemies()
    {
        animalIndex = Random.Range(0, enemies.Length - 1);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
            Instantiate(enemies[animalIndex], spawnPosition, enemies[animalIndex].transform.rotation);
    }
}
