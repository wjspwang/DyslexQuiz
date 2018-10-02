using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManipulatingLevelSelectMenuControlScript : MonoBehaviour
{

    public Button level02Button, level03Button, level04Button, level05Button,
        level06Button, level07Button, level08Button, level09Button, level10Button,
        level11Button, level12Button, level13Button, level14Button, level15Button,
        level16Button, level17Button, level18Button, level19Button, level20Button;
    int ManipulateLevelPassed;


    // Use this for initialization
    void Start()
    {
        ManipulateLevelPassed = PlayerPrefs.GetInt("ManipulatePass");
        level02Button.interactable = false;
        level03Button.interactable = false;
        level04Button.interactable = false;
        level05Button.interactable = false;
        level06Button.interactable = false;
        level07Button.interactable = false;
        level08Button.interactable = false;
        level09Button.interactable = false;
        level10Button.interactable = false;
        level11Button.interactable = false;
        level12Button.interactable = false;
        level13Button.interactable = false;
        level14Button.interactable = false;
        level15Button.interactable = false;
        level16Button.interactable = false;
        level17Button.interactable = false;
        level18Button.interactable = false;
        level19Button.interactable = false;
        level20Button.interactable = false;

        ManipulateLevelPassed -= 68;
        Debug.Log(ManipulateLevelPassed + "");
        switch (ManipulateLevelPassed)
        {
            case 1:
                level02Button.interactable = true;
                break;
            case 2:
                level02Button.interactable = true;
                level03Button.interactable = true;
                break;
            case 3:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                break;
            case 4:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                break;
            case 5:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                break;
            case 6:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                break;
            case 7:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                break;
            case 8:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                break;
            case 9:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                break;
            case 10:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                break;
            case 11:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                break;
            case 12:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                level13Button.interactable = true;
                break;
            case 13:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                level13Button.interactable = true;
                level14Button.interactable = true;
                break;
            case 14:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                level13Button.interactable = true;
                level14Button.interactable = true;
                level15Button.interactable = true;
                break;
            case 15:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                level13Button.interactable = true;
                level14Button.interactable = true;
                level15Button.interactable = true;
                level16Button.interactable = true;
                break;
            case 16:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                level13Button.interactable = true;
                level14Button.interactable = true;
                level15Button.interactable = true;
                level16Button.interactable = true;
                level17Button.interactable = true;
                break;
            case 17:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                level13Button.interactable = true;
                level14Button.interactable = true;
                level15Button.interactable = true;
                level16Button.interactable = true;
                level17Button.interactable = true;
                level18Button.interactable = true;
                break;
            case 18:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                level13Button.interactable = true;
                level14Button.interactable = true;
                level15Button.interactable = true;
                level16Button.interactable = true;
                level17Button.interactable = true;
                level18Button.interactable = true;
                level19Button.interactable = true;
                break;
            case 19:
                level02Button.interactable = true;
                level03Button.interactable = true;
                level04Button.interactable = true;
                level05Button.interactable = true;
                level06Button.interactable = true;
                level07Button.interactable = true;
                level08Button.interactable = true;
                level09Button.interactable = true;
                level10Button.interactable = true;
                level11Button.interactable = true;
                level12Button.interactable = true;
                level13Button.interactable = true;
                level14Button.interactable = true;
                level15Button.interactable = true;
                level16Button.interactable = true;
                level17Button.interactable = true;
                level18Button.interactable = true;
                level19Button.interactable = true;
                level20Button.interactable = true;
                break;

        }


    }




    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPrefs()
    {
        level02Button.interactable = false;
        level03Button.interactable = false;
        level04Button.interactable = false;
        level05Button.interactable = false;
        level06Button.interactable = false;
        level07Button.interactable = false;
        level08Button.interactable = false;
        level09Button.interactable = false;
        level10Button.interactable = false;
        level11Button.interactable = false;
        level12Button.interactable = false;
        level13Button.interactable = false;
        level14Button.interactable = false;
        level15Button.interactable = false;
        level16Button.interactable = false;
        level17Button.interactable = false;
        level18Button.interactable = false;
        level19Button.interactable = false;
        level20Button.interactable = false;
        PlayerPrefs.DeleteKey("ManipulatePass");
    }
}
