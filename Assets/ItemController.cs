using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private GameObject pick;
    [SerializeField] private GameObject boots;
    [SerializeField] private GameObject machette;
    [SerializeField] private GameObject helmet;
    

    [SerializeField] private int itemSelectNum;
    [SerializeField] private GameObject RockPrefab;
    [SerializeField] private GameObject SmashedRockPrefab;

    [SerializeField] private GameObject VulturePrefab;

    [SerializeField] private GameObject flame1;
    [SerializeField] private GameObject flame2;



    public float maxForce;
    public float minForce;
    //public float radius;
    public float jumpForce;

    

    private Vector3 smashedVector3 = new Vector3();
    private Vector2 forceDirection = new Vector2();
    private Vector2 bootsForce = new Vector2();


    Rigidbody2D rb;


    void Start()
    {
        itemSelectNum = PlayerPrefs.GetInt("itemnum");

        

        if(itemSelectNum == 1)
        {
            
            TagChanger("enemy", "enemy");
            rb = GetComponent<Rigidbody2D>();
            
            GetItem(true, true, false, false);  
            bootsForce = new Vector2(0f, jumpForce);
            InvokeRepeating("GraplingSkill", 10f, 10.0f);

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

    private void Update()
    {
        
    }


    private void GetItem(bool b_Pick , bool b_Boots, bool b_Machette , bool b_Helmet)
    {
        pick.SetActive(b_Pick);
        boots.SetActive(b_Boots);
        machette.SetActive(b_Machette);
        helmet.SetActive(b_Helmet);
    }

    private void TagChanger(string rock, string vulture)
    {
        RockPrefab.tag = rock;
        VulturePrefab.tag = vulture;

    }

    void GraplingSkill()
    {

        flame1.SetActive(true);
        flame2.SetActive(true);
        rb.velocity = bootsForce;

        StartCoroutine(CloseFlames());
    }

    IEnumerator CloseFlames()
    {
        yield return new WaitForSeconds(1f);

        flame1.SetActive(false);
        flame2.SetActive(false);
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
