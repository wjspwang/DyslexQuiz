using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArithLevelSelectMenuControlScript : MonoBehaviour
{

    public Button level02Button, level03Button, level04Button, level05Button,
        level06Button, level07Button, level08Button, level09Button, level10Button,
        level11Button, level12Button, level13Button, level14Button, level15Button,
        level16Button, level17Button, level18Button, level19Button, level20Button;
    int ArithLevelPassed;
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


    // Use this for initialization
    void Start()
    {
        ArithLevelPassed = PlayerPrefs.GetInt("ArithPass");
        level02Button.interactable = false;
        level03Button.interactable = false;
        level04Button.interactable = false;
        level05Button.interactable = false;
        level06Button.interactable = false;
        level07Button.interactable = false;
        level08Button.interactable = false;
        level09Button.interactable = false;
        level10Button.interactable = false;


        ArithLevelPassed -= 110;
        Debug.Log(ArithLevelPassed + " levels passed");

        switch (ArithLevelPassed)
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
        for(int i = 0; i < 20; i++)
        {
            if (PlayerPrefs.HasKey("ArithRetriesLevel " + i))
            {
                Debug.Log("ArithRetriesLevel " + i.ToString() +" "+PlayerPrefs.GetInt("ArithRetriesLevel "+i));
                if(PlayerPrefs.GetInt("ArithRetriesLevel " + i) < 1)
                {
                    inGameMenuStars[starArray].SetActive(true);
                    inGameMenuStars[starArray + 1].SetActive(true);
                    inGameMenuStars[starArray + 2].SetActive(true);
                }
                else if (PlayerPrefs.GetInt("ArithRetriesLevel " + i) < 3)
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
                Debug.Log("No such key as " + "ArithRetriesLevel " + i.ToString());
            }
        }




    }




    public void levelToLoad(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPlayerPrefs()
    {
        ResetStars();
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
        PlayerPrefs.DeleteKey("ArithPass");
        for(int i=0; i < 20; i++)
        {
            
            PlayerPrefs.DeleteKey("ArithRetriesLevel " + i);
            Debug.Log(PlayerPrefs.GetInt("ArithRetriesLevel " + i));
        }
    }
}
