using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerNameScript : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    string playerName;

    public Text InputText;
    public Text DisplayUser;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        playerName = PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {
        if (DisplayUser != null)
        {
            DisplayName();
        }
        
    }

    void DisplayName()
    {
        if (playerName == null)
        {
            Debug.Log("username is null");
            return;
        }

        DisplayUser.text = playerName;
    }

    public void SaveUserName(Text username)
    {
        if (username.text == null || username.text == "")
        {
            return;
        }

        if (PlayerPrefs.GetString("username") == username.text)
        {
            Debug.Log("Welcome Back! " + PlayerPrefs.GetString("username"));
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            return;
        }
        
        PlayerPrefs.SetString("username", username.text);
        Debug.Log(PlayerPrefs.GetString("username"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
