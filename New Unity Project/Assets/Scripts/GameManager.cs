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
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        ModePrefSelector(SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.DeleteKey(ModePref + LevelText.text);

        //Debug.Log("Start:" + PlayerPrefs.GetInt("ArithRetries" + LevelText.text));
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
  
    void Update()
    {
        
        Retry.text = PlayerPrefs.GetInt(ModePref + LevelText.text) + "";
        //Debug.Log(ModePref + LevelText.text + " " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
    public void UserSelectAButton()
    {
        
        if (currentQuestion.isA)
        {
            CorrectText.SetActive(true);
            Debug.Log("Correct");
            LevelDesign.SetTrigger("Correct");
            NextQuestion();
            LevelControlScript.instance.youWin();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLose();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLose();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLose();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseBlending();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseBlending();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseBlending();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
            Debug.Log(ModePref + LevelText.text + "is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseDeleting();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseDeleting();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseDeleting();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseManipulating();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseManipulating();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseManipulating();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseRhyming();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseRhyming();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseRhyming();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));


        }
        else
        {
            WrongText.SetActive(true);
            PlayerPrefs.SetInt(ModePref + LevelText.text , PlayerPrefs.GetInt(ModePref + LevelText.text) +1);
            Debug.Log(ModePref + LevelText.text + " is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));


        }
        else
        {
            WrongText.SetActive(true);
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
            Debug.Log(ModePref + LevelText.text + " is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
            Debug.Log(ModePref + LevelText.text + " is " + PlayerPrefs.GetInt(ModePref + LevelText.text));
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithSub();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));


        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithSub();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);

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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithSub();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);

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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithMult();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithMult();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithMult();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));
        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithDiv();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithDiv();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
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
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text));

        }
        else
        {
            WrongText.SetActive(true);
            Debug.Log("Wrong");
            LevelDesign.SetTrigger("Wrong");
            LevelControlScript.instance.youLoseArithDiv();
            PlayerPrefs.SetInt(ModePref + LevelText.text, PlayerPrefs.GetInt(ModePref + LevelText.text) + 1);
        }

        //StartCoroutine(TransitionToNextQuestion());
    }
}
