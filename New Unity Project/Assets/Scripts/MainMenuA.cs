using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuA : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    public void PlayModeB()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 22);
    }
    public void PlayModeC()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 43);
    }
    public void PlayModeD()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
}
