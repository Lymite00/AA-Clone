using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ignePrefabs;


    void igneSpawner()
    {
        Instantiate(ignePrefabs, transform.position, transform.rotation);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            igneSpawner();
        }
    }
}
