using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{

    float stepSize;

    float jumpSize;

    // Start is called before the first frame update
    void Start()
    {
        stepSize = 1f;

        jumpSize = stepSize * 1.15f;
    }

    // Update is called once per frame
    void Update()
    {        
        
    }

    public void Jump()
    {        
        jumpSize = jumpSize * 1.15f;

        this.transform.position = this.transform.position + new Vector3(0, 0, jumpSize);       
    }


    public void SmallStepForward()
    {
        this.transform.position = this.transform.position + new Vector3(0, 0, stepSize/2);
    }

    public void StepForward()
    {
        this.transform.position = this.transform.position + new Vector3(0, 0, stepSize);
    }

    public void StepBackwards()
    {
        this.transform.position = this.transform.position - new Vector3(0, 0, stepSize);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")   
        {
            Debug.Log("You Moron!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("You reached the desk!");
        }
    }

}
