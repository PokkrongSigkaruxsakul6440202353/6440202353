using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class watcherbullet : MonoBehaviour
{
    float movespeed = 7f;
    Rigidbody2D rb;
    //public GameObject p;
    player target;
    Vector2 movedirection;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //target = p.transform;
        target = GameObject.FindObjectOfType<player>();
        movedirection = (target.transform.position - transform.position).normalized*movespeed;
        rb.velocity = new Vector2 (movedirection.x, movedirection.y);
        Destroy(gameObject,3f);
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        if(collision.gameObject.name.Equals("player"))
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
        */
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
           
        }
    }
}
