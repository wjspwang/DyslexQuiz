using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsManager : MonoBehaviour
{
    public GameObject[] inGameMenuStars;
    public GameObject[] winPanelStars;

    private int collectedStarsCount = 0;
    private const int MAXIMUM_STARS_COUNT = 3;

    public void ResetStars()
    {
        collectedStarsCount = 0;
        for (int i = 0; i < inGameMenuStars.Length; i++)
        {
            inGameMenuStars[i].SetActive(false);
            winPanelStars[i].SetActive(false);
        }
    }

    public void starsCollected()
    {
        if(collectedStarsCount > MAXIMUM_STARS_COUNT - 1)
        {
            return;
        }
        inGameMenuStars[collectedStarsCount].SetActive(true);
        winPanelStars[collectedStarsCount].SetActive(false);
        collectedStarsCount++;
    }
}
