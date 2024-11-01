using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchershoot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    public GameObject player;
    float firerate;
    float nextfire;
    public float chasedistance;

    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        firerate = 1f;
        nextfire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        checkiftimetofire();
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
    }

    void checkiftimetofire()
    {
        if((Time.time>nextfire) && (distance < chasedistance))
        {
            Instantiate(bullet,transform.position,Quaternion.identity);
            nextfire = Time.time + firerate;
        }
    }
}
