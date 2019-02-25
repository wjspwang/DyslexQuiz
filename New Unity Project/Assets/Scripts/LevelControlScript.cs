using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class LevelControlScript : MonoBehaviour {

    public static LevelControlScript instance = null;
    GameObject levelSign;
    int sceneIndex, levelPassed, BlendLevelPassed, DeleteLevelPassed,
        ManipulateLevelPassed, RhymeLevelPassed, ArithLevelPassed,
        ArithSubLevelPassed, ArithMultLevelPassed, ArithDivLevelPassed, retry;

    // Use this for initialization
    void Start() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        levelSign = GameObject.Find("LevelNumber");

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "LevelPassed");
        BlendLevelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "BlendPass");
        DeleteLevelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "DeletePass");
        ManipulateLevelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "ManipulatePass");
        RhymeLevelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "RhymePass");
        ArithLevelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "ArithPass");
        ArithSubLevelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "ArithSubPass");
        ArithMultLevelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "ArithMultPass");
        ArithDivLevelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "ArithDivPass");
        retry = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + " Level " + "LevelNumber");

    }
    //YOU WIN METHODS
    public void youWin()
    {
        if (sceneIndex == 25)
            Invoke("loadCountingMenu", 1f);
        else
        {
            if (levelPassed < sceneIndex)
                PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "LevelPassed", sceneIndex);
            Invoke("loadCountingMenu", 1f);

        }
        Invoke("loadCountingMenu", 1f);
    }
    public void youWinBlend()
    {
        if (sceneIndex == 46)
            Invoke("loadBlendingMenu", 1f);
        else
        {
            if (BlendLevelPassed < sceneIndex)
                PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "BlendPass", sceneIndex);
            Invoke("loadBlendingMenu", 1f);
        }
        Invoke("loadBlendingMenu", 1f);
    }

    public void youWinDelete()
    {
        if (sceneIndex == 67)
            Invoke("loadDeletingMenu", 1f);
        else
        {
            if (DeleteLevelPassed < sceneIndex)
                PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "DeletePass", sceneIndex);
            Invoke("loadDeletingMenu", 1f);
        }
        Invoke("loadDeletingMenu", 1f);
    }

    public void youWinManipulate()
    {
        if (sceneIndex == 88)
            Invoke("loadManipulatingMenu", 1f);
        else
        {
            if (ManipulateLevelPassed < sceneIndex)
                PlayerPrefs.SetInt(PlayerPrefs.GetString("username")+"ManipulatePass", sceneIndex);
            Invoke("loadManipulatingMenu", 1f);
        }
        Invoke("loadManipulatingMenu", 1f);
    }

    public void youWinRhyme()
    {
        if (sceneIndex == 109)
            Invoke("loadRhymingMenu", 1f);
        else
        {
            if (RhymeLevelPassed < sceneIndex)
                PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "RhymePass", sceneIndex);
            Invoke("loadRhymingMenu", 1f);
        }
        Invoke("loadRhymingMenu", 1f);
    }
    public void youWinArith()
    {
        
   
        if (sceneIndex == 120)
            Invoke("loadArithMenu", 1f);
        else
        {
            if (ArithLevelPassed < sceneIndex)
                PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "ArithPass", sceneIndex);
            Invoke("loadArithMenu", 1f);
        }
        Invoke("loadArithMenu", 1f);
    }
    public void youWinArithSub()
    {
        if (sceneIndex == 146)
            Invoke("loadArithSubMenu", 1f);
        else
        {
            if (ArithSubLevelPassed < sceneIndex)
                PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "ArithSubPass", sceneIndex);
            Invoke("loadArithSubMenu", 1f);
        }
        Invoke("loadArithSubMenu", 1f);
    }
    public void youWinArithMult()
    {
        if (sceneIndex == 156)
            Invoke("loadArithMultMenu", 1f);
        else
        {
            if (ArithMultLevelPassed < sceneIndex)
                PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "ArithMultPass", sceneIndex);
            Invoke("loadArithMultMenu", 1f);
        }
        Invoke("loadArithMultMenu", 1f);
    }
    public void youWinArithDiv()
    {
        if (sceneIndex == 166)
            Invoke("loadArithDivMenu", 1f);
        else
        {
            if (ArithDivLevelPassed < sceneIndex)
                PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "ArithDivPass", sceneIndex);
            Invoke("loadArithDivMenu", 1f);

        }
        Invoke("loadArithDivMenu", 1f);
    }

    //YOU LOSE METHODS
    public void youLose()
    {
        Invoke("ReloadLevel", 1f);
    }

    public void youLoseBlending()
    {
        Invoke("ReloadLevel", 1f);
    }

    public void youLoseDeleting()
    {
        Invoke("ReloadLevel", 1f);
    }

    public void youLoseManipulating()
    {
        Invoke("ReloadLevel", 1f);
    }

    public void youLoseRhyming()
    {
        Invoke("ReloadLevel", 1f);
    }
    public void youLoseArith()
    {
        Invoke( "ReloadLevel", 1f);
    }
    public void youLoseArithSub()
    {
        Invoke("ReloadLevel", 1f);
    }
    public void youLoseArithMult()
    {
        Invoke("ReloadLevel", 1f);
    }
    public void youLoseArithDiv()
    {
        Invoke("ReloadLevel", 1f);
    }

    //Reload
    public void ReloadLevel()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    //LOAD NEXT LEVEL
    public void loadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
	//LOAD MENU
    void loadCountingMenu()
    {
        SceneManager.LoadScene("CountingLevelSelect");
    }

    void loadBlendingMenu()
    {
        SceneManager.LoadScene("BlendingLevelSelect");
    }

    void loadDeletingMenu()
    {
        SceneManager.LoadScene("DeletingLevelSelect");
    }

    void loadManipulatingMenu()
    {
        SceneManager.LoadScene("ManipulatingLevelSelect");
    }

    void loadRhymingMenu()
    {
        SceneManager.LoadScene("RhymingLevelSelect");
    }
    void loadArithMenu()
    {
        SceneManager.LoadScene("ArithLevelSelect");
    }
    void loadArithSubMenu()
    {
        SceneManager.LoadScene("SubtractLevelSelect");
    }
    void loadArithMultMenu()
    {
        SceneManager.LoadScene("MultiplyLevelSelect");
    }
    void loadArithDivMenu()
    {
        SceneManager.LoadScene("DivisionLevelSelect");
    }

}
