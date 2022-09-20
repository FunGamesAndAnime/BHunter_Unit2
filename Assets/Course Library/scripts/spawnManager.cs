using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalprefabs;
    private float xPosRange = 13;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.5f);
        SpawnRandomAnimal();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void SpawnRandomAnimal()
    {
        float randxPos = Random.Range(-xPosRange, xPosRange);
        int animalprefabindex = Random.Range(0, animalprefabs.Length);
        Instantiate(animalprefabs[animalprefabindex], new Vector3(randxPos, 0, 21), animalprefabs[animalprefabindex].transform.rotation);
    }
}

