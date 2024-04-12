using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Challenge2
{

    public class SpawnManagerX : MonoBehaviour
    {
        public GameObject[] ballPrefabs;

        private float spawnLimitXLeft = -22;
        private float spawnLimitXRight = 7;
        private float spawnPosY = 30;

        private float startDelay = 1.0f;

        // Start is called before the first frame update
        void Start()
        {
            float spawnInterval = Random.Range(3, 5);
            InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        }

        // Spawn random ball at random x position at top of play area
        void SpawnRandomBall()
        {
            Debug.Log("SpawnRandomBall");

            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
            // Random ballPrefabs index
            int ballPrefabIndex = Random.Range(0, ballPrefabs.Length - 1);

            Debug.Log("SpawnRandomBall " + ballPrefabIndex);

            var ballPrefab = ballPrefabs[ballPrefabIndex];

            // instantiate ball at random spawn location
            Instantiate(ballPrefab, spawnPos, ballPrefab.transform.rotation);
        }

    }

}