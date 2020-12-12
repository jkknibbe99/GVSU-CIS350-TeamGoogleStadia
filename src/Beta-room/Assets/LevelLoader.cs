using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public GameObject cam;
    public int level;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            SceneManager.LoadScene(level);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(cam);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
