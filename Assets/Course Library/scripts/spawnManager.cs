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
        
    }

    // Update is called once per frame
    void Update()
    {
        float randxPos = Random.Range(-xPosRange, xPosRange);
        int animalprefabindex = Random.Range(0, animalprefabs.Length);
        if (Input.GetKeyDown(KeyCode.S))
        {
         Instantiate(animalprefabs[animalprefabindex], new Vector3(randxPos, 0, 21), animalprefabs[animalprefabindex].transform.rotation);
        }
    }
}
