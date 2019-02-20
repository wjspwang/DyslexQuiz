using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlendingLevelSelectMenuControlScript : MonoBehaviour
{

    public Button level02Button, level03Button, level04Button, level05Button,
        level06Button, level07Button, level08Button, level09Button, level10Button,
        level11Button, level12Button, level13Button, level14Button, level15Button,
        level16Button, level17Button, level18Button, level19Button, level20Button;
    int BlendLevelPassed;
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
    public void ModePrefelector(int index)
    {
        int curr_scene = SceneManager.GetActiveScene().buildIndex;
        if (curr_scene >= 5 && curr_scene <= 25)
        {
            ModePref = "CountingRetries";
        }
        else if (curr_scene >= 26 && curr_scene <= 46)
        {
            ModePref = "BlendingRetries";
        }
        else if (curr_scene >= 47 && curr_scene <= 67)
        {
            ModePref = "DeletingRetries";
        }
        else if (curr_scene >= 68 && curr_scene <= 88)
        {
            ModePref = "ManipulatingRetries";
        }
        else if (curr_scene >= 89 && curr_scene <= 109)
        {
            ModePref = "RhymingRetries";
        }
        else if (curr_scene >= 110 && curr_scene <= 120)
        {
            ModePref = "ArithRetries";
        }
        else if (curr_scene == 134 || (curr_scene >= 137 && curr_scene <= 146 ))
        {
            ModePref = "ArithSubRetries";
        }
        else if (curr_scene == 135 || (curr_scene >= 147 && curr_scene <= 156))
        {
            ModePref = "ArithMultRetries";
        }
        else if (curr_scene == 136 || (curr_scene >= 157 && curr_scene <= 166))
        {
            ModePref = "ArithDivRetries";
        }
    }
    // Use this for initialization
    void Start()
    {
        ModePrefelector(SceneManager.GetActiveScene().buildIndex);
        BlendLevelPassed = PlayerPrefs.GetInt("BlendPass");
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

        BlendLevelPassed -= 26;

        switch (BlendLevelPassed)
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
        int starArray = 0;
        for (int i = 0; i < 20; i++)
        {
            if (PlayerPrefs.HasKey(ModePref+ "Level " + i))
            {
                Debug.Log(ModePref+ "Level " + i.ToString() + " " + PlayerPrefs.GetInt(ModePref+ "Level " + i));
                if (PlayerPrefs.GetInt(ModePref+ "Level " + i) < 1)
                {
                    inGameMenuStars[starArray].SetActive(true);
                    inGameMenuStars[starArray + 1].SetActive(true);
                    inGameMenuStars[starArray + 2].SetActive(true);
                }
                else if (PlayerPrefs.GetInt(ModePref+ "Level " + i) < 3)
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
                Debug.Log("No such key as " + ModePref + i.ToString());
            }
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
        PlayerPrefs.DeleteKey("BlendPass");
        for (int i = 0; i < 20; i++)
        {

            PlayerPrefs.DeleteKey(ModePref+ "Level " + i);
            Debug.Log(PlayerPrefs.GetInt(ModePref+ "Level " + i));
        }
        ResetStars();
    }
}
