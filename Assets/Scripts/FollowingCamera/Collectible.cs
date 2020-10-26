using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<LameKeyboardControls>())
        {
            SpawnMiniObstacles();

            collision.gameObject.GetComponent<LameKeyboardControls>().IncreaseHits();

            Destroy(this.gameObject);
        }
    }


    private void SpawnMiniObstacles()
    {
        Vector3 posLeft = this.transform.position;
        posLeft.x -= 1f;

        Vector3 posRight = this.transform.position;
        posRight.x += 1f;

        GameObject miniClone = Instantiate(this.gameObject);
        miniClone.transform.position = posLeft;
        //miniClone.transform.localScale = this.transform.localScale * 0.5f;
        //miniClone.gameObject.name = "MiniCloneL";

        miniClone = Instantiate(this.gameObject);
        miniClone.transform.position = posRight;
        //miniClone.transform.localScale = this.transform.localScale * 0.5f;
        //miniClone.gameObject.name = "MiniCloneR";
       
    }
}
