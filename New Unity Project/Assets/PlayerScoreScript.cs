using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text engScore;
    public Text mathScore;
    public Text total;
    int eng_score=0;
    int math_score=0;
    float total_score = 0;
    void Start()
    {
        displayScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //string user = PlayerPrefs.GetString("username");
    public void displayScores()
    {
        eng_score = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "BlendScore") +
                    PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "DeleteScore") +
                    PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "ManipScore") +
                    PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "CountScore") +
                    PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "RhymeScore");

        math_score = PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "DivScore") +
                     PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "ArithScore") +
                     PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "MultScore") +
                     PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "SubScore");

        PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "EngScore", eng_score);
        PlayerPrefs.SetInt(PlayerPrefs.GetString("username") + "MathScore", math_score);
        total_score = ((float)eng_score + (float)math_score)/140*100;
        Debug.Log(total_score);
        total.text = total_score.ToString("0.00");
        engScore.text = eng_score + "/100";
        mathScore.text = math_score + "/40";
      
    }


}
