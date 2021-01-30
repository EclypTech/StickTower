using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDen : MonoBehaviour
{
    public GameObject MovedPlat;
    public float speed;
    public Vector3 left = new Vector3();
    public Vector3 right = new Vector3();
    Vector3 nextPos;



    // Start is called before the first frame update
    private void Start()
    {
        left.x = gameObject.transform.position.x - 2.5f;
        left.y = gameObject.transform.position.y;

        right.x = gameObject.transform.position.x + 2.5f;
        right.y = gameObject.transform.position.y;

        nextPos = left;
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position == left)
            nextPos = right;

        if (transform.position == right)
            nextPos = left;

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
            collision.collider.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
            collision.collider.transform.SetParent(null);
    }

}