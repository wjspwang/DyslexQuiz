using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (sceneIndex == 128 || sceneIndex == 177)
            {
                SceneManager.LoadScene(178);
            }
            else if (sceneIndex == 123)
            {
                SceneManager.LoadScene(3);
            }
            else
            {
                SceneManager.LoadScene(4);
            }
            
        }
    }


}
