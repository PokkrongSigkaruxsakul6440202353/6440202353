using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalcontroller : MonoBehaviour
{
    public Transform destination;
    GameObject player;
    Animation anim;
    Rigidbody2D playerRb;
    public soundeffectplayer portalcontroller_soundeffectplayer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = player.GetComponent<Animation>();
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(Vector2.Distance(player.transform.position,transform.position)>1f)
            {
                //
                StartCoroutine(PortalIn());
            }
           
        }
    }

    IEnumerator PortalIn()
    {
        
        playerRb.simulated = false;
        //portalcontroller_soundeffectplayer.wave();
        anim.Play("portalin");
        StartCoroutine(MoveInPortal());
        yield return new WaitForSeconds(0.5f);
        player.transform.position = destination.position;
        anim.Play("portalout");
        yield return new WaitForSeconds(0.5f);
        playerRb.simulated = true;
        
    }

    IEnumerator MoveInPortal()
    {
        float timer = 0;
        while(timer<0.5f)
        {
            player.transform.position = Vector2.MoveTowards(player.transform.position, transform.position, 3 * Time.deltaTime);
            yield return new WaitForEndOfFrame();
            timer += Time.deltaTime;
        }
    }
}
