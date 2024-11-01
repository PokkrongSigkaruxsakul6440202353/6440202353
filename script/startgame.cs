using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    // Start is called before the first frame update
    public int gamestartscene;
    public GameObject Box;

    public void click()
    {
        Debug.Log("gg");
    }
    public void startgame1()
    {
        SceneManager.LoadScene(gamestartscene);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
