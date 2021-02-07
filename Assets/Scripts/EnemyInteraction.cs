using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInteraction : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)  // When touch..
    {
        if (collision.transform.tag == "enemy")
        {

            transform.eulerAngles = new Vector2(180, 0);
            animator.SetTrigger("IsDead");
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(collision.gameObject);
        }
    }

}
