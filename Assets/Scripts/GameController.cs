using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject myObstaclePrefab;

    float range = 3f;

    int maxObstacles = 2000;

    // Start is called before the first frame update
    void Start()
    {
        GameObject whatever;        
        /*
        int counter = 0;

        while(counter < maxObstacles)
        {
            whatever = Instantiate(myObstaclePrefab);
            whatever.transform.position = new Vector3(Random.Range(-range, range), Random.Range(0, range), Random.Range(-range, range));
            counter++;
        }
        */
        for(int counter = 0; counter < maxObstacles; counter++)
        {
            whatever = Instantiate(myObstaclePrefab);
            whatever.transform.position = new Vector3(Random.Range(-range, range), Random.Range(0, range), Random.Range(-range, range));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
