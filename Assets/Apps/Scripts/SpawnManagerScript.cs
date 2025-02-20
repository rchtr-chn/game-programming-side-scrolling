using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    private float timerCount;
    public GameObject prefab;
    public GameObject player;
    public float timerCap;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = player.transform.position.x + x;
        float negDistance = player.transform.position.x - x;
        Vector2 spawnPos = new Vector2(Random.Range(distance, 45f), 0);
        Vector2 negSpawnPos = new Vector2(Random.Range(-45f, negDistance), 0);
        timerCount += Time.deltaTime;
        if(timerCount >= timerCap)
        {
            timerCount = 0;
            float choice = Random.Range(0f, 1f);
            if(choice <= 0.5f)
                Instantiate(prefab, spawnPos, Quaternion.identity);
            else
                Instantiate(prefab, negSpawnPos, Quaternion.identity);
        }
    }
}
