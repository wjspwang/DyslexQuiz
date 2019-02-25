using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArithDivLevelSelectMenuControlScript : MonoBehaviour
{
    public Text score;
    int ActiveStarCounter = 0;
    public Button level02Button, level03Button, level04Button, level05Button,
        level06Button, level07Button, level08Button, level09Button, level10Button,
        level11Button, level12Button, level13Button, level14Button, level15Button,
        level16Button, level17Button, level18Button, level19Button, level20Button;
    int ArithDivLevelPassed;
    public GameObject[] inGameMenuStars;

    public GameObject[] levelNumber;


    private int collectedStarsCount = 0;

    private const int MAXIMUM_STARS_COUNT = 6;


    public void ResetStars()
    {
        collectedStarsCount = 0;
        for (int i = 0; i < inGameMenuStars.Length; i++)
        {
            inGameMenuStars[i].SetActive(false);
        }
    }

    public void starsCollected()
    {
        if (collectedStarsCount > MAXIMUM_STARS_COUNT - 1)
        {
            return;
        }
        inGameMenuStars[collectedStarsCount].SetActive(true);
        collectedStarsCount++;
        Debug.Log(collectedStarsCount);
    }
    private string ModePref;
    public void ModePrefSelector(int index)
    {
        int curr_scene = SceneManager.GetActiveScene().buildIndex;
        if (curr_scene >= 5 && curr_scene <= 25)
        {
            ModePref = PlayerPrefs.GetString("username") + "CountingRetries";
        }
        else if (curr_scene >= 26 && curr_scene <= 46)
        {
            ModePref = PlayerPrefs.GetString("username") + "BlendingRetries";
        }
        else if (curr_scene >= 47 && curr_scene <= 67)
        {
            ModePref = PlayerPrefs.GetString("username") + "DeletingRetries";
        }
        else if (curr_scene >= 68 && curr_scene <= 88)
        {
            ModePref = PlayerPrefs.GetString("username") + "ManipulatingRetries";
        }
        else if (curr_scene >= 89 && curr_scene <= 109)
        {
            ModePref = PlayerPrefs.GetString("username") + "RhymingRetries";
        }
        else if (curr_scene >= 110 && curr_scene <= 120)
        {
            ModePref = PlayerPrefs.GetString("username") + "ArithRetries";
        }
        else if (curr_scene == 134 || (curr_scene >= 137 && curr_scene <= 146))
        {
            ModePref = PlayerPrefs.GetString("username") + "ArithSubRetries";
        }
        else if (curr_scene == 135 || (curr_scene >= 147 && curr_scene <= 156))
        {
            ModePref = PlayerPrefs.GetString("username") + "ArithMultRetries";
        }
        else if (curr_scene == 136 || (curr_scene >= 157 && curr_scene <= 166))
        {
            ModePref = PlayerPrefs.GetString("username") + "ArithDivRetries";
        }
    }


    // Use this for initialization
    void Start()
    {
        ModePrefSelector(SceneManager.GetActiveScene().buildIndex);
        ArithDivLevelPassed = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "ArithDivPass");
        level02Button.interactable = false;
        level03Button.interactable = false;
        level04Button.interactable = false;
        level05Button.interactable = false;
        level06Button.interactable = false;
        level07Button.interactable = false;
        level08Button.interactable = false;
        level09Button.interactable = false;
        level10Button.interactable = false;
        /*
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
        */

        ArithDivLevelPassed -= 156;
        Debug.Log(ArithDivLevelPassed + "ArithDiv levels passed");

        switch (ArithDivLevelPassed)
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
               

        }
        int starArray = 0;
        for (int i = 0; i < 20; i++)
        {
            if (PlayerPrefs.HasKey(ModePref + "Level " + i))
            {
                Debug.Log(ModePref + "Level " + i.ToString() + " " + PlayerPrefs.GetInt(ModePref + "Level " + i));
                if (PlayerPrefs.GetInt(ModePref + "Level " + i) < 1)
                {
                    inGameMenuStars[starArray].SetActive(true);
                    inGameMenuStars[starArray + 1].SetActive(true);
                    inGameMenuStars[starArray + 2].SetActive(true);
                }
                else if (PlayerPrefs.GetInt(ModePref + "Level " + i) < 3)
                {
                    inGameMenuStars[starArray].SetActive(true);
                    inGameMenuStars[starArray + 1].SetActive(true);
                }
                else
                {
                    inGameMenuStars[starArray].SetActive(true);
                }
                starArray += 3;
            }
            else
            {
                Debug.Log("No such key as " + ModePref + "Level " + i.ToString());
            }
        }
        for (int j = 0; j < 30; j++)
        {
            if (inGameMenuStars[j].activeSelf == true)
            {
                ActiveStarCounter++;

            }

        }
        PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "DivScore", ActiveStarCounter);
        score.text = "Score: " + PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "DivScore");
        Debug.Log("DivScore is " + PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "DivScore"));

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
        /*level11Button.interactable = false;
        level12Button.interactable = false;
        level13Button.interactable = false;
        level14Button.interactable = false;
        level15Button.interactable = false;
        level16Button.interactable = false;
        level17Button.interactable = false;
        level18Button.interactable = false;
        level19Button.interactable = false;
        level20Button.interactable = false;
        */
        PlayerPrefs.DeleteKey(PlayerPrefs.GetString("username") + "ArithDivPass");
        for (int i = 0; i < 20; i++)
        {
            //ModePref + LevelText.text
            PlayerPrefs.DeleteKey(ModePref + "Level " + i);
            Debug.Log(ModePref + "Level " + i + " = " + PlayerPrefs.GetInt(ModePref + "Level " + i));
        }
        ResetStars();
    }
}
