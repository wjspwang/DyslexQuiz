using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreList : MonoBehaviour
{
    public GameObject PlayerScoreEntryPrefab;
    ScoreManager scoreManager;
    int lastChangeCounter;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ScoreManager>();
        lastChangeCounter = scoreManager.GetChangeCounter();

    }

    // Update is called once per frame
    void Update()
    {

        if (scoreManager == null)
        {
            Debug.LogError("1");
            return;
        }
        /*
        if(scoreManager.GetChangeCounter() == lastChangeCounter)
        {
            return;
        }
        */

        while (this.transform.childCount > 0 )
        {
            Transform c = this.transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }
        
        string[] names = scoreManager.GetPlayerNames("English");


        foreach (string name in names)
        {
            GameObject go = (GameObject)Instantiate(PlayerScoreEntryPrefab);
            go.transform.SetParent(this.transform);
            go.transform.Find("Username").GetComponent<Text>().text = name;
            go.transform.Find("English").GetComponent<Text>().text = scoreManager.GetScore(name, "English").ToString();
            go.transform.Find("Math").GetComponent<Text>().text = scoreManager.GetScore(name, "Math").ToString();
        }
    }

}
