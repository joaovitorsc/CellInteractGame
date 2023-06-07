using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonAnwser : MonoBehaviour
{
    QuizManager quizManager;
    [SerializeField ]public string ButtonAnswer;
   
    private void Start()
    {
        quizManager = GameObject.FindGameObjectWithTag("QuizManager").GetComponent<QuizManager>();
    }
    public void CheckAnswer()
    {
        if (ButtonAnswer ==  quizManager.Answer)
        {
           quizManager.correctAnswer += 1;
        }
        else
        {
            quizManager.wrongAnswer += 1;
        }
        quizManager.DrawQuestions();
        quizManager.UpdateScore();
    }
}
