using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using TMPro;

public class FlashCardManager : MonoBehaviour
{

    //public GameObject CorrectText;

    public FlashCard[] flashcardTexts;
    private static List<FlashCard> unansweredQuestions;


    private FlashCard currentQuestion;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private float timeBetweenQuestions = 1f;




    void Start()
    {
        

        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = flashcardTexts.ToList<FlashCard>();
        }

        GetRandomQuestion();


    }
    void Update()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            int CurrentSceneNum = SceneManager.GetActiveScene().buildIndex;
            if (CurrentSceneNum > 166 && CurrentSceneNum < 177)
            {
                SceneManager.LoadScene(178);
            }
            else
            {
            SceneManager.LoadScene(123);
            }
            

            unansweredQuestions.Clear();
        }
    }

            public void GetRandomQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;
    }

    public void NextWord()
    {
        StartCoroutine(TransitionToNextQuestion());
    }

    public void NextNumber()
    {
        int SceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (SceneIndex != 176)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(178);
        }
        
    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}
