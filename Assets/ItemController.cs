using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private GameObject pick;
    [SerializeField] private GameObject grapling;
    [SerializeField] private GameObject machette;
    [SerializeField] private GameObject helmet;

    [SerializeField] private int itemSelectNum;
    
    [SerializeField] private GameObject RockPrefab;
    [SerializeField] private GameObject SmashedRockPrefab;

    [SerializeField] private GameObject VulturePrefab;

    [SerializeField] private GameObject Machette;

    public float maxForce;
    public float minForce;
    public float radius;

    private Vector3 smashedVector3 = new Vector3();
    private Vector2 forceDirection = new Vector2();


    void Start()
    {
        itemSelectNum = PlayerPrefs.GetInt("itemnum");
        

        if(itemSelectNum == 1)
        {
            GetItem(false, true, false, false);
            TagChanger("enemy", "enemy");
        }
        else if(itemSelectNum == 2)
        {
            GetItem(false, false, true, false);
            TagChanger("enemy", "NotEnemy");
        }
        else if(itemSelectNum == 3)
        {
            GetItem(true, false, false, true);
            TagChanger("NotEnemy","enemy");
            

        }
        else
        {
            GetItem(true, false, false, false);
            TagChanger("enemy", "enemy");
        }
    }

    
    private void GetItem(bool b_Pick , bool b_Grapling, bool b_Machette , bool b_Helmet)
    {
        pick.SetActive(b_Pick);
        grapling.SetActive(b_Grapling);
        machette.SetActive(b_Machette);
        helmet.SetActive(b_Helmet);
    }

    private void TagChanger(string rock, string vulture)
    {
        RockPrefab.tag = rock;
        VulturePrefab.tag = vulture;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "NotEnemy" && itemSelectNum == 3) {

            smashedVector3 =  collision.gameObject.transform.position;

            GameObject smashedRock = Instantiate(SmashedRockPrefab, smashedVector3, Quaternion.identity);

            Destroy(collision.gameObject);

            Debug.Log(smashedRock.transform.childCount);

            for(int i = 0; i < smashedRock.transform.childCount; i++)
            {
                forceDirection = new Vector2(Random.Range(minForce, maxForce), Random.Range(minForce, maxForce));
                
                var rb = smashedRock.transform.GetChild(i).GetComponent<Rigidbody2D>();
                
                if (rb != null)
                {
                    rb.AddForce(forceDirection);
                }
            }
        }

        if(collision.transform.tag == "NotEnemy" && itemSelectNum == 2)
        {
            collision.gameObject.transform.eulerAngles = new Vector2(180, 0) ;
            collision.gameObject.GetComponent<Animator>().enabled = false;
            collision.gameObject.AddComponent<Rigidbody2D>();
            

        }

    }

}
