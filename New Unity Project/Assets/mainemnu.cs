using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainemnu : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene(0);
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadScene(2);
            }

            if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                SceneManager.LoadScene(3);
            }

            
        }
    }
}
