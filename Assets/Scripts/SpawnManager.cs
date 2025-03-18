using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefabs;
    private Vector3 spawmPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }
    void SpawnObstacle()
    {
        Instantiate(obstaclePrefabs, spawmPos, obstaclePrefabs.transform.rotation);
    }
}
