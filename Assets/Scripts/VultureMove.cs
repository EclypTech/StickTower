using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VultureMove : MonoBehaviour
{
    public GameObject MovedVulture;
    public float speed = 2f;
    public Vector3 left = new Vector3();
    public Vector3 right = new Vector3();
    Vector3 nextPos;

    private void Start()
    {
        left.x = -3.5f;
        left.y = gameObject.transform.position.y;

        right.x = 3.5f;
        right.y = gameObject.transform.position.y;

        nextPos = left;
    }


    private void Update()
    {
        if (transform.position == left)
        {
        nextPos = right;
        MovedVulture.transform.eulerAngles = new Vector2(0, 180);

        }
        else if (transform.position == right)
        {
        nextPos = left;
        MovedVulture.transform.eulerAngles = new Vector2(0, 0);
        }
            


        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

}
