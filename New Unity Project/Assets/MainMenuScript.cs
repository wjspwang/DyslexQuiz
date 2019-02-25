using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void PlayGame()
    {
        if (PlayerPrefs.GetString("username") != "")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            Debug.Log(PlayerPrefs.GetString("username") + " ! ");
            return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Escape))
            Application.Quit();
    }

    public void LogOut(int level)
    {
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene(level);
    }

}
