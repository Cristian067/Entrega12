using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] bulletsArray;
    private int bulletIndex;

    private float spawnRangeX = 6f;
    private float spawnPosZ = 0f;
    private float spawnPosY = 15f;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 2f;





    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("SpawnRandomBullets", startDelay, spawnInterval);



    }

    // Update is called once per frame
    void Update()
    {





    }

    private void SpawnRandomBullets()
    {

        bulletIndex = Random.Range(0, bulletsArray.Length);

        Instantiate(bulletsArray[bulletIndex], RandomSpawn(), Quaternion.identity);


    }

    private Vector3 RandomSpawn()
    {
        float linea = Random.Range(-spawnRangeX, spawnRangeX);

        return new Vector3(linea, spawnPosY, spawnPosZ);
    }
}
