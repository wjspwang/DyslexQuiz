using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScoreManager : MonoBehaviour
{
    Dictionary<string, Dictionary<string, int>> playerScores;
    int ChangeCounter = 0;

    void Start()
    {
        SetScore(PlayerPrefs.GetString("username"),"English", 51);
        SetScore(PlayerPrefs.GetString("username"), "Math", 42);

        SetScore("joe", "English", 31);
        SetScore("joe", "Math", 25);

        SetScore("dan", "English", 61);
        SetScore("dan", "Math", 29);

      

       // Debug.Log("My score is " + GetScore("havenfalls123", "English"));
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
    public void SetScore(string username,string scoreType, int value)
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
