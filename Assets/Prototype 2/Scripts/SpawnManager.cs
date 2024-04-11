using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;

    private float spawnZ = 30f;
    private float rangeX = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Mathf.CeilToInt(Random.Range(0, AnimalPrefabs.Length));
        var prefab = AnimalPrefabs[animalIndex];
        Instantiate(prefab, new Vector3(
            Mathf.CeilToInt(Random.Range(-rangeX, rangeX)), 0, spawnZ
        ), prefab.transform.rotation);
    }
}
