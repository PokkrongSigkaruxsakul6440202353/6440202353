using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class json : MonoBehaviour
{public string a;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [System.Serializable]
    public class Article
    {
        public string title;
        public string body;
    }

    public Article LoadArticle(string jsonString)
    {
        return JsonUtility.FromJson<Article>(jsonString);
    }

    // Update is called once per frame
    void Update()
    {
        LoadArticle("body");
    }
}
