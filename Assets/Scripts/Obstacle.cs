using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
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
        if(collision.gameObject.GetComponent<LameKeyboardControls>())
        {
            Debug.Log("Greg hit an obstacle");


            GameObject clone = Instantiate(this.gameObject);

            Vector3 clonePos = this.transform.position;
            clonePos.x -= 1f;

            clone.transform.position = clonePos;


            clone = Instantiate(this.gameObject);

            clonePos = this.transform.position;
            clonePos.x += 1f;

            clone.transform.position = clonePos;

            collision.gameObject.GetComponent<LameKeyboardControls>().IncreaseHits();


            Destroy(this.gameObject);
        }
        
    }
}
