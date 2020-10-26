using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject myObstaclePrefab;

    public float maxRange;

    public int numberOfObstacles;

    // Start is called before the first frame update
    void Start()
    {   

        for(int counter = 0; counter < numberOfObstacles; counter++)
        {
            GameObject tempClone = Instantiate(myObstaclePrefab);
            tempClone.transform.position = new Vector3(Random.Range(-maxRange, maxRange), 0.1f, Random.Range(-maxRange, maxRange));
        }
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
