using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitsFactory : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject unitPrefab;

    public float spawnRate = 1;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnRate)
        {
            timer = 0;
            var index = Random.Range(0, spawnPoints.Length);
            Instantiate(unitPrefab, spawnPoints[index].transform.position, Quaternion.identity);
        }
    }
}
