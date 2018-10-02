using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadingLevelSelectMenu : MonoBehaviour {



    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }
}
