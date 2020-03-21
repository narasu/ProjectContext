using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostAnswerButton : UIButton
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Text question;
    [SerializeField] private Text inputText;
    [SerializeField][Tooltip("0 for question, 1 for answer")] private int queryType;
    

    protected override void Start()
    {
        base.Start();

    }

    protected override void TaskOnClick()
    {
        InputStorage.WriteAnswer(question.text.ToString(), inputText.text.ToString());
        AnswerText answerText = canvas.GetComponent<AnswerText>();
        answerText.Refresh();
    }
}
