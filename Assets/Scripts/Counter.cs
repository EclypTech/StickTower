
using UnityEngine;
public class Counter : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.GetComponent<MyScript>().score += 1;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}