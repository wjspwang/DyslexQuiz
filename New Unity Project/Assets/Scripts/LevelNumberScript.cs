using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelNumberScript : MonoBehaviour {

    Text text;
    int sceneIndex;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex > 5 && sceneIndex < 26)
        {
            sceneIndex -= 5;
        }
        else if (sceneIndex > 26 && sceneIndex < 47)
        {
            sceneIndex -= 26;
        }
        else if (sceneIndex > 47 && sceneIndex < 68)
        {
            sceneIndex -= 47;
        }
        else if (sceneIndex > 68 && sceneIndex < 89)
        {
            sceneIndex -= 68;
        }
        else if (sceneIndex > 89 && sceneIndex < 110)
        {
            sceneIndex -= 89;
        }
        else if (sceneIndex > 110 && sceneIndex < 121)
        {
            sceneIndex -= 110;
        }else if (sceneIndex > 136 && sceneIndex < 147)
        {
            sceneIndex -= 136;
        }else if (sceneIndex > 146 && sceneIndex < 157)
        {
            sceneIndex -= 146;
        }else if(sceneIndex > 156 && sceneIndex < 167)
        {
            sceneIndex -= 156;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Level " + sceneIndex;
	}
}
