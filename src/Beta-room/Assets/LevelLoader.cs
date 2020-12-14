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

    public void changePosition()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        GameObject player = GameObject.Find("Player");

        if (scene == 1)
        {
            player.transform.position = new Vector3(-12, -40, 0);
        }
        else if (scene == 2)
        {
            player.transform.position = new Vector3(-14, 1, 0);
        }
        else if (scene == 3)
        {
            player.transform.position = new Vector3(-5, -3, 0);
        }
        else if (scene == 4)
        {
            player.transform.position = new Vector3(-6, 3, 0);
        }
        else if (scene == 5)
        {
            player.transform.position = new Vector3(1, -2, 0);
        }
        else if (scene == 0)
        {
            player.transform.position = new Vector3(-13, -2, 0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        changePosition();
        DontDestroyOnLoad(cam);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
