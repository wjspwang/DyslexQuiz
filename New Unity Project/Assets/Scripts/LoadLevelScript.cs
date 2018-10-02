using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadLevelScript : MonoBehaviour {


    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }
    void Update()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            int CurrentSceneNum = SceneManager.GetActiveScene().buildIndex;
            if(sceneIndex == 4)
            {
            SceneManager.LoadScene(3);
            }else if(sceneIndex == 3)
            {
                SceneManager.LoadScene(2);
            }else if (sceneIndex == 2)
            {
                SceneManager.LoadScene(1);
            }else if (sceneIndex == 1)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
