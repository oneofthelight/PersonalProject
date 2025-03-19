using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefabs;
    private Vector3 spawmPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    public bool isIdle = true;
    private GameObject obstacle =  null;
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        if(isIdle )
        {
            Invoke("SpawnObstacle", Random.Range(0.0f, 1.0f));
            isIdle = false;
        }
       
    }
    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefabs, spawmPos, obstaclePrefabs.transform.rotation);
        }
    }
}
