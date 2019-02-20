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

            if (sceneIndex == 5 || sceneIndex == 26 || sceneIndex == 47 || sceneIndex == 68 || sceneIndex == 89)
            {
                SceneManager.LoadScene(4);
                
            }
            else if (sceneIndex > 5 && sceneIndex < 26)
            {
                SceneManager.LoadScene(5);
                
            }
            else if (sceneIndex > 26 && sceneIndex < 47)
            {
                SceneManager.LoadScene(26);
                
            }
            else if (sceneIndex > 47 && sceneIndex < 68)
            {
                SceneManager.LoadScene(47);
                
            }
            else if (sceneIndex > 68 && sceneIndex < 89)
            {
                SceneManager.LoadScene(68);
                
            }
            else if (sceneIndex > 89 && sceneIndex < 110)
            {
                SceneManager.LoadScene(89);
                
            }
            else if (sceneIndex > 110 && sceneIndex < 121)
            {
                SceneManager.LoadScene(110);
                
            }
            else if (sceneIndex == 110 || sceneIndex == 134 || sceneIndex == 135 || sceneIndex == 136)
            {
                SceneManager.LoadScene(133);
                
            }
            else if (sceneIndex == 5 || sceneIndex == 26 || sceneIndex == 47 || sceneIndex == 68 || sceneIndex == 89)
            {
                SceneManager.LoadScene(4);
                
            }
            else if (sceneIndex == 133)
            {
                SceneManager.LoadScene(178);
                
            }
            else if (sceneIndex > 136 && sceneIndex < 147)
            {
                SceneManager.LoadScene(134);
                
            }
            else if (sceneIndex > 146 && sceneIndex < 157)
            {
                SceneManager.LoadScene(135);
                
            }
            else if (sceneIndex > 156 && sceneIndex < 167)
            {
                SceneManager.LoadScene(136);
                
            }
            if(sceneIndex == 178)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
