using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScoreManager : MonoBehaviour
{
    Dictionary<string, Dictionary<string, int>> playerScores;
    int ChangeCounter = 0;
    //int ProfileCount = 1;
    
    void Start()
    {
        
        for(int i = 0; i < 10 ; i++)
        {

            SetScore(PlayerPrefs.GetString("Profile name" + i), "English", PlayerPrefs.GetInt("Profile EngScore" + i));
            SetScore(PlayerPrefs.GetString("Profile name" + i), "Math", PlayerPrefs.GetInt("Profile MathScore" + i));
            

            /*
            PlayerPrefs.DeleteKey("Profile name" + i);
            PlayerPrefs.DeleteKey("Profile EngScore" + i);
            PlayerPrefs.DeleteKey("Profile MathScore" + i); 
            */

        }

    }
    void Update()
    {
        
        for(int i=0; i < 10; i++)
        {
            if(PlayerPrefs.GetString("username") == PlayerPrefs.GetString("Profile name" + i))
            {
                PlayerPrefs.SetInt("Counter", i);
                i = 11;
                PlayerPrefs.SetInt("Profile EngScore" + PlayerPrefs.GetInt("Counter"), PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "EngScore"));
                PlayerPrefs.SetInt("Profile MathScore" + PlayerPrefs.GetInt("Counter"), PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "MathScore"));
                Debug.Log(PlayerPrefs.GetInt("Profile EngScore" + PlayerPrefs.GetInt("Counter")));
            }

        }
        
            //PlayerPrefs.SetInt("Profile EngScore" + userid, PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "EngScore"));
            //PlayerPrefs.SetInt("Profile MathScore" + userid, PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "MathScore"));

        

    }
    
    public void addProfile()
    {
        int userid = PlayerPrefs.GetInt("userid");
        if (PlayerPrefs.HasKey(PlayerPrefs.GetString("username")) == false)
        {
            PlayerPrefs.SetInt("userid", userid + 1);
            Debug.Log("user id is" + userid);
        }
        Debug.Log(PlayerPrefs.HasKey(PlayerPrefs.GetString("username")) == false);
        Debug.Log(PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "EngScore") + " " + PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "MathScore"));

        PlayerPrefs.SetString("Profile name" + userid, PlayerPrefs.GetString("username"));
        PlayerPrefs.SetInt(PlayerPrefs.GetString("Profile name" + userid),0);
     PlayerPrefs.SetInt("Profile EngScore" + userid, PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "EngScore"));
     PlayerPrefs.SetInt("Profile MathScore" + userid, PlayerPrefs.GetInt(PlayerPrefs.GetString("username") + "MathScore"));
      
    }
 

    void Init()
    {
        if (playerScores != null)
            return;


        playerScores = new Dictionary<string, Dictionary<string, int>>();
    }
     public int GetScore(string username, string scoreType) 
    {
        Init();
        if (playerScores.ContainsKey(username) == false){
            //no record for this user
            return 0;
        }
        if(playerScores[username].ContainsKey(scoreType) == false)
        {
            return 0;
        }
        return playerScores[username][scoreType];

    }
    public void SetScore(string username,string scoreType, int value )
    {
        Init();
        ChangeCounter++;
        if (playerScores.ContainsKey(username) == false)
        {
            playerScores[username] = new Dictionary<string, int>();
        }   
        playerScores[username][scoreType] = value;

    }
    public void ChangeScore(string username,string scoreType, int amount )
    {
        Init();
        int currScore = GetScore(username, scoreType);
        SetScore(username, scoreType, currScore + amount);
    }
    public string [] GetPlayerNames()
    {
        Init();
        return playerScores.Keys.ToArray();
    }
    public string[] GetPlayerNames(string sortingScoreType)
    {
        Init();
        return playerScores.Keys.OrderByDescending(n => GetScore(n, sortingScoreType)).ToArray();
    }
    public int GetChangeCounter()
    {
        return ChangeCounter;
    }
}
