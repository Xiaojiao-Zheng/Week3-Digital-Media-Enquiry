using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LameKeyboardControls : MonoBehaviour
{

    private int numberOfHits = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.tag == "Desk")
        {
            Debug.Log("You Win!");

            Debug.Log("You hit "+ numberOfHits);

            Debug.Log("You missed " + GameObject.FindObjectsOfType<Collectible>().Length);
        }
    }

    public void IncreaseHits()
    {
        numberOfHits++;
    }
}
