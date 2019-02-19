using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour {

    //public GameObject CorrectText;

    public Question[] questions;
    private static List<Question> unansweredQuestions;
    int QuestionNumberIndex;
    

    private Question currentQuestion;

    [SerializeField]
    private Text LevelText;
    [SerializeField]
    private Text factText;
    [SerializeField]
    private Text textA;
    [SerializeField]
    private Text textB;
    [SerializeField]
    private Text textC;
    [SerializeField]
    private Text Retry;

    [SerializeField]
    private Animator LevelDesign;

    [SerializeField]
    private GameObject CorrectText;

    [SerializeField]
    private GameObject WrongText;

    [SerializeField]
    private float timeBetweenQuestions = 1f;

    


    void Start()
    {
        
        PlayerPrefs.DeleteKey("ArithRetries" + LevelText.text);
        Debug.Log("Start:" + PlayerPrefs.GetInt("ArithRetries" + LevelText.text));
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        int QuestionNumberIndex = Random.Range(0, unansweredQuestions.Count);
        Debug.Log(QuestionNumberIndex + "");
        SetCurrentQuestion();
        CorrectText.SetActive(false);
        WrongText.SetActive(false);

       
    }
    void QuestionSetSelect()
    {
        /*
        int CurrentSceneNum = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(CurrentSceneNum + " CurrentSceneNum");
        if (CurrentSceneNum > 5 && CurrentSceneNum < 26)
        {
            CountingQuestionSet();
        }
        else if (CurrentSceneNum > 26 && CurrentSceneNum < 47)
        {
            BlendingQuestionSet();
        }else if(CurrentSceneNum > 47 && CurrentSceneNum < 68)
        {
            DeletingQuestionSet();
        }else if (CurrentSceneNum > 68 && CurrentSceneNum < 89)
        {
            ManipulatingQuestionSet();
        }else if (CurrentSceneNum > 89 && CurrentSceneNum < 110)
        {
            RhymingQuestionSet();
        }else if (CurrentSceneNum > 110 && CurrentSceneNum < 121)
        {
            ArithQuestionSet();
        }
        */

        //int QuestionNumberIndex = Random.Range(0, unansweredQuestions.Count);

        
    }
    void Update()
    {
        Retry.text = PlayerPrefs.GetInt("ArithRetries" + LevelText.text) + "";
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (sceneIndex == 5 || sceneIndex == 26 || sceneIndex == 47 || sceneIndex == 68 || sceneIndex == 89)
            {
                SceneManager.LoadScene(4);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex > 5 && sceneIndex < 26)
            {
                SceneManager.LoadScene(5);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex > 26 && sceneIndex < 47)
            {
                SceneManager.LoadScene(26);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex > 47 && sceneIndex < 68)
            {
                SceneManager.LoadScene(47);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex > 68 && sceneIndex < 89)
            {
                SceneManager.LoadScene(68);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex > 89 && sceneIndex < 110)
            {
                SceneManager.LoadScene(89);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex > 110 && sceneIndex < 121)
            {
                SceneManager.LoadScene(110);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex == 110 || sceneIndex == 134 || sceneIndex == 135 || sceneIndex == 136)
            {
                SceneManager.LoadScene(133);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex == 5 || sceneIndex == 26 || sceneIndex == 47 || sceneIndex == 68 || sceneIndex == 89)
            {
                SceneManager.LoadScene(4);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex == 133)
            {
                SceneManager.LoadScene(178);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex > 136 && sceneIndex < 147)
            {
                SceneManager.LoadScene(134);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex > 146 && sceneIndex < 157)
            {
                SceneManager.LoadScene(135);
                unansweredQuestions.Clear();
            }
            else if (sceneIndex > 156 && sceneIndex < 167)
            {
                SceneManager.LoadScene(136);
                unansweredQuestions.Clear();
            }
        }
    }
    void CountingQuestionSet()
    {
        QuestionNumberIndex = SceneManager.GetActiveScene().buildIndex;

        QuestionNumberIndex -= 6;


    }

    void BlendingQuestionSet()
    {
        QuestionNumberIndex = SceneManager.GetActiveScene().buildIndex;

        QuestionNumberIndex -= 27;

    }

    void DeletingQuestionSet()
    {
        QuestionNumberIndex = SceneManager.GetActiveScene().buildIndex;

        QuestionNumberIndex -= 48;

    }

    void ManipulatingQuestionSet()
    {
        QuestionNumberIndex = SceneManager.GetActiveScene().buildIndex;

        QuestionNumberIndex -= 69;
    }

    void RhymingQuestionSet()
    {
        QuestionNumberIndex = SceneManager.GetActiveScene().buildIndex;

        QuestionNumberIndex -= 90;
    }

    void ArithQuestionSet()
    {
        QuestionNumberIndex = SceneManager.GetActiveScene().buildIndex;

        QuestionNumberIndex -=  111;
    }

    void SetCurrentQuestion()
    {
        
        int QuestionNumberIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[QuestionNumberIndex];
        

        factText.text = currentQuestion.fact;
        textA.text = currentQuestion.ChoiceA;
        textB.text = currentQuestion.ChoiceB;
        textC.text = currentQuestion.ChoiceC;

    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextQuestion()
    {
        StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectAButton()
    {
        
        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWin();

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLose();
        }

        //StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectBButton()
    {
        //animator.SetTrigger("False");
        if (currentQuestion.isB)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWin();

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLose();
        }

        //StartCoroutine(TransitionToNextQuestion());
    }

    public void UserSelectCButton()
    {
        //animator.SetTrigger("False");
        if (currentQuestion.isC)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWin();

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLose();
        }

        //StartCoroutine(TransitionToNextQuestion());
    }

    public void select_A()
    {
        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinBlend();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseBlending();
        }
    }
    public void select_B()
    {
        if (currentQuestion.isB)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinBlend();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseBlending();
        }
    }
    public void select_C()
    {
        if (currentQuestion.isC)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinBlend();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseBlending();
        }
    }
    public void D_buttonA()
    {
        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinDelete();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseDeleting();
        }
    }
    public void D_buttonB()
    {
        if (currentQuestion.isB)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinDelete();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseDeleting();
        }
    }
    public void D_buttonC()
    {
        if (currentQuestion.isC)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinDelete();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseDeleting();
        }
    }

    public void M_buttonA()
    {
        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinManipulate();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseManipulating();
        }
    }
    public void M_buttonB()
    {
        if (currentQuestion.isB)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinManipulate();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseManipulating();
        }
    }
    public void M_buttonC()
    {
        if (currentQuestion.isC)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinManipulate();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseManipulating();
        }
    }
    public void R_buttonA()
    {
        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinRhyme();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseRhyming();
        }
    }
    public void R_buttonB()
    {
        if (currentQuestion.isB)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinRhyme();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseRhyming();
        }
    }
    public void R_buttonC()
    {
        if (currentQuestion.isC)
        {

            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinRhyme();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseRhyming();
        }
    }
    public void A_buttonA()
    {
        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArith();
            PlayerPrefs.SetInt("ArithRetries" + LevelText.text, PlayerPrefs.GetInt("ArithRetries" + LevelText.text));


        }
        else
        {
            WrongText.SetActive(true);
            PlayerPrefs.SetInt("ArithRetries" + LevelText.text , PlayerPrefs.GetInt("ArithRetries" + LevelText.text) +1);
            Debug.Log("ArithRetries" + LevelText.text + " is " + PlayerPrefs.GetInt("ArithRetries" + LevelText.text));
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArith();
        }
    }
    public void A_buttonB()
    {
        if (currentQuestion.isB)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArith();
            PlayerPrefs.SetInt("ArithRetries" + LevelText.text, PlayerPrefs.GetInt("ArithRetries" + LevelText.text));


        }
        else
        {
            WrongText.SetActive(true);
            PlayerPrefs.SetInt("ArithRetries" + LevelText.text, PlayerPrefs.GetInt("ArithRetries" + LevelText.text) + 1);
            Debug.Log("ArithRetries" + LevelText.text + " is " + PlayerPrefs.GetInt("ArithRetries" + LevelText.text));
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArith();

        }
    }
    public void A_buttonC()
    {
        if (currentQuestion.isC)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArith();
            PlayerPrefs.SetInt("ArithRetries" + LevelText.text, PlayerPrefs.GetInt("ArithRetries" + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            PlayerPrefs.SetInt("ArithRetries" + LevelText.text, PlayerPrefs.GetInt("ArithRetries" + LevelText.text) + 1);
            Debug.Log("ArithRetries" + LevelText.text + " is " + PlayerPrefs.GetInt("ArithRetries" + LevelText.text));
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArith();

        }
    }
    public void Sub_buttonA()
    {
        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArithSub();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithSub();
        }
    }
    public void Sub_buttonB()
    {
        if (currentQuestion.isB)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArithSub();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithSub();

        }
    }
    public void Sub_buttonC()
    {
        if (currentQuestion.isC)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArithSub();


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithSub();

        }
    }
    public void Mult_ButtonA()
    {

        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArithMult();

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithMult();
        }

        //StartCoroutine(TransitionToNextQuestion());
    }

    public void Mult_ButtonB()
    {
        //animator.SetTrigger("False");
        if (currentQuestion.isB)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArithMult();

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithMult();
        }

        //StartCoroutine(TransitionToNextQuestion());
    }

    public void Mult_ButtonC()
    {
        //animator.SetTrigger("False");
        if (currentQuestion.isC)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArithMult();

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithMult();
        }

        //StartCoroutine(TransitionToNextQuestion());
    }
    public void Div_ButtonA()
    {

        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArithDiv();

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithDiv();
        }

        //StartCoroutine(TransitionToNextQuestion());
    }

    public void Div_ButtonB()
    {
        //animator.SetTrigger("False");
        if (currentQuestion.isB)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArithDiv();

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithDiv();
        }

        //StartCoroutine(TransitionToNextQuestion());
    }

    public void Div_ButtonC()
    {
        //animator.SetTrigger("False");
        if (currentQuestion.isC)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWinArithDiv();

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithDiv();
        }

        //StartCoroutine(TransitionToNextQuestion());
    }
}
