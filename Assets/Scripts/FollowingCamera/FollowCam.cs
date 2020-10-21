using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    //offset will be the distance between the camera (the object that has this script) and our target (in this case, the player, as the camera will always
    //follow the player
    private Vector3 offset;


    //as this is public, we MUST set this target on Unity Editor (dragging our player there).
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {

        //the offset could be set by hand (you could declare it as a regular Vector3 as you already know)

        //here, I set my offset on the scene and in the first frame (before everyone moves), I'm calculating it by taking the difference between
        //initial positions
        offset = this.transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        //at every frame, I'll change the position of the camera, making it the target's position (the player's position) + the offset
        //this makes the cam "follow" the player
        this.transform.position = target.position + offset;
    }
}
