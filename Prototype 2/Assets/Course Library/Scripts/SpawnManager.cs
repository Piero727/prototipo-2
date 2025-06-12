using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] animalPrefabs2;
    public GameObject[] animalPrefabs3;
    int positnX = 13;
    int positnZ = 20;
    float startDelay = 3.0f;
    float spawnInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomBall2", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomBall3", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int num = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-positnX, positnX), 0, positnZ);
        Instantiate(animalPrefabs[num], spawnPosition, animalPrefabs[num].transform.rotation);
    }

    void SpawnRandomBall2()
    {
        int num = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-19, 0, Random.Range(-6, 6));

        Instantiate(animalPrefabs2[num], spawnPos, animalPrefabs2[num].transform.rotation);
    }

    void SpawnRandomBall3()
    {
        int num = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(23, 0, Random.Range(-6, 6));

        Instantiate(animalPrefabs3[num], spawnPos, animalPrefabs3[num].transform.rotation);
    }
}
