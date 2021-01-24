using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFaller : MonoBehaviour
{
    public Transform target;         // Determine the target which means player.
    public float smoothSpeed = .3f;  // Add smooth. It doesnt use. We can delete.
  

    // Update is called once per frame
    void Update()
    {
        if(target.position.y > transform.position.y) // If players position gonna bigger then the camera..
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);  // Get new position to the camera to the target.
            transform.position = newPos;

        }
    }
}
