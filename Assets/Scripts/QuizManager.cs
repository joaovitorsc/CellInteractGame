using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;
using TMPro;

public class QuizManager : MonoBehaviour
{
    [System.Serializable]
    public class Question
    {
        public string TextQuestion;
        public string Answer;
    }

    public List<Question> Questions;

    [SerializeField] TextMeshProUGUI TextQuestion;
    public int QuestionIndex = 0;
    public string Answer;
    [SerializeField]TextMeshProUGUI CorrectText, WrongText;
    [HideInInspector]public int correctAnswer, wrongAnswer;

    public void DrawQuestions()
    {
        TextQuestion.text = Questions[QuestionIndex].TextQuestion;
        Answer = Questions[QuestionIndex].Answer;
        QuestionIndex++;
    }
    public void UpdateScore()
    {
        CorrectText.text = correctAnswer.ToString();
        WrongText.text = wrongAnswer.ToString();
    }
}
