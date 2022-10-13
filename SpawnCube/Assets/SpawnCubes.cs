using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    public GameObject cube;
    public float timer;
    public float respawnTime;
    public GameObject RespawnTimer;

    void Start()
    {
        RespawnTimer = GameObject.Find("CreateTimerInput");
    }


    void Update()
    {
        timer += Time.deltaTime;

        respawnTime = RespawnTimer.GetComponent<ChangeRespawnTimer>().newTime;

        if (timer >= respawnTime)
        {
            Object.Instantiate(cube,transform);
            timer = 0;
        }

        
    }
}
