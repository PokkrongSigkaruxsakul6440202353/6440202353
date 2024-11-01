using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    

    Transform target;
    Vector3 velocity = Vector3.zero;

    [Range(0, 1)]

    public float smoothtime;

    public Vector3 positionoffset;
    private void Awake()
    {
        //DontDestroyOnLoad(transform.gameObject);
        target = GameObject.FindGameObjectWithTag("Player").transform;
        //target = GameObject.FindGameObjectWithTag("ship").transform;
    }
    
    // Update is called once per frame
    public void LateUpdate()
    {
        Vector3 targetPosition = target.position+positionoffset;
        transform.position = Vector3.SmoothDamp(transform.position,targetPosition,ref velocity,smoothtime);
    }
}
