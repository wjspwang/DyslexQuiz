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
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        BlendLevelPassed = PlayerPrefs.GetInt("BlendPass");
        DeleteLevelPassed = PlayerPrefs.GetInt("DeletePass");
        ManipulateLevelPassed = PlayerPrefs.GetInt("ManipulatePass");
        RhymeLevelPassed = PlayerPrefs.GetInt("RhymePass");
        ArithLevelPassed = PlayerPrefs.GetInt("ArithPass");
        ArithSubLevelPassed = PlayerPrefs.GetInt("ArithSubPass");
        ArithMultLevelPassed = PlayerPrefs.GetInt("ArithMultPass");
        ArithDivLevelPassed = PlayerPrefs.GetInt("ArithDivPass");
        retry = PlayerPrefs.GetInt("Level " + "LevelNumber");

    }
    //YOU WIN METHODS
    public void youWin()
    {
        if (sceneIndex == 25)
            Invoke("loadCountingMenu", 1f);
        else
        {
            if (levelPassed < sceneIndex)
                PlayerPrefs.SetInt("LevelPassed", sceneIndex);
            Invoke("loadNextLevel", 1f);
            
        }
    }
    public void youWinBlend()
    {
        if (sceneIndex == 46)
            Invoke("loadBlendingMenu", 1f);
        else
        {
            if (BlendLevelPassed < sceneIndex)
                PlayerPrefs.SetInt("BlendPass", sceneIndex);
            Invoke("loadNextLevel", 1f);
        }
    }

    public void youWinDelete()
    {
        if (sceneIndex == 67)
            Invoke("loadDeletingMenu", 1f);
        else
        {
            if (DeleteLevelPassed < sceneIndex)
                PlayerPrefs.SetInt("DeletePass", sceneIndex);
            Invoke("loadNextLevel", 1f);
        }
    }

    public void youWinManipulate()
    {
        if (sceneIndex == 88)
            Invoke("loadManipulatingMenu", 1f);
        else
        {
            if (ManipulateLevelPassed < sceneIndex)
                PlayerPrefs.SetInt("ManipulatePass", sceneIndex);
            Invoke("loadNextLevel", 1f);
        }
    }

    public void youWinRhyme()
    {
        if (sceneIndex == 109)
            Invoke("loadRhymingMenu", 1f);
        else
        {
            if (RhymeLevelPassed < sceneIndex)
                PlayerPrefs.SetInt("RhymePass", sceneIndex);
            Invoke("loadNextLevel", 1f);
        }
    }
    public void youWinArith()
    {
        
   
        if (sceneIndex == 120)
            Invoke("loadArithMenu", 1f);
        else
        {
            if (ArithLevelPassed < sceneIndex)
                PlayerPrefs.SetInt("ArithPass", sceneIndex);
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
                PlayerPrefs.SetInt("ArithSubPass", sceneIndex);
            Invoke("loadNextLevel", 1f);
        }
    }
    public void youWinArithMult()
    {
        if (sceneIndex == 156)
            Invoke("loadArithMultMenu", 1f);
        else
        {
            if (ArithMultLevelPassed < sceneIndex)
                PlayerPrefs.SetInt("ArithMultPass", sceneIndex);
            Invoke("loadNextLevel", 1f);
        }
    }
    public void youWinArithDiv()
    {
        if (sceneIndex == 166)
            Invoke("loadArithDivMenu", 1f);
        else
        {
            if (ArithDivLevelPassed < sceneIndex)
                PlayerPrefs.SetInt("ArithDivPass", sceneIndex);
            Invoke("loadNextLevel", 1f);

        }
    }

    //YOU LOSE METHODS
    public void youLose()
    {
        Invoke("loadCountingMenu", 1f);
    }

    public void youLoseBlending()
    {
        Invoke("loadBlendingMenu", 1f);
    }

    public void youLoseDeleting()
    {
        Invoke("loadDeletingMenu", 1f);
    }

    public void youLoseManipulating()
    {
        Invoke("loadManipulatingMenu", 1f);
    }

    public void youLoseRhyming()
    {
        Invoke("loadRhymingMenu", 1f);
    }
    public void youLoseArith()
    {
        PlayerPrefs.SetInt("Level " + "LevelNumber", +1);
        Invoke( "ReloadLevel", 1f);
    }
    public void youLoseArithSub()
    {
        Invoke("loadArithSubMenu", 1f);
    }
    public void youLoseArithMult()
    {
        Invoke("loadArithMultMenu", 1f);
    }
    public void youLoseArithDiv()
    {
        Invoke("loadArithDivMenu", 1f);
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
