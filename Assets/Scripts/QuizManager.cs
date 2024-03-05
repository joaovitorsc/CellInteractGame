using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    [System.Serializable]
    public class Question
    {
        public string TextQuestion;
        public string Answer;
    }

    public List<Question> Questions;
    [SerializeField] GameObject PanelVictory,PanelLose;
    [SerializeField] TextMeshProUGUI TextQuestion;
    public int QuestionIndex = 0;
    public string Answer;
    [SerializeField] TextMeshProUGUI CorrectText, WrongText;
    [HideInInspector] public int correctAnswer, wrongAnswer;

    private void Start()
    {
        DrawQuestions();
    }
    public void DrawQuestions()
    {
        if (QuestionIndex >= Questions.Count)
        {
            CheckWinorLose();
        }
        else
        {
            TextQuestion.text = Questions[QuestionIndex].TextQuestion;
            Answer = Questions[QuestionIndex].Answer;
            QuestionIndex++;
        }
    }
    public void UpdateScore()
    {
        CorrectText.text = correctAnswer.ToString();
        WrongText.text = wrongAnswer.ToString();
    }
    void CheckWinorLose()
    {
        if (correctAnswer >= 7)
        {
            PanelVictory.SetActive(true);
        }
        else
        {
            PanelLose.SetActive(true);
        }
    }
   public  void LoadOtherScene (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
