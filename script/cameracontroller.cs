using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    private static bool retainCamera;

    void Awake()
    {
        //vcam = GetComponent<CinemachineVirtualCamera>();
        DontDestroyOnLoad(GameObject.Find("Main Camera"));
    }

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (!retainCamera)
        {
            retainCamera = true;
            DontDestroyOnLoad(transform.gameObject);
            Debug.Log("Camera Loaded");

        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Camera Destroyed!");
        }
    }
}