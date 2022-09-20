using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory_out_of_bouns : MonoBehaviour
{
    private float topOfSceane = 30.0f;
    private float bottomOfSceane = -15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topOfSceane)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomOfSceane)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");

        }
    }
}
