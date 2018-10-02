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
            if (sceneIndex == 128)
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                SceneManager.LoadScene(4);
            }
            
        }
    }


}
