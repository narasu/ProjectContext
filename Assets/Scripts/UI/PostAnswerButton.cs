using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostAnswerButton : UIButton
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Text question;
    [SerializeField] private InputField inputField;
    

    protected override void Start()
    {
        base.Start();

    }

    protected override void TaskOnClick()
    {
        if (inputField.text != "")
        {
            InputStorage.WriteAnswer(question.text.ToString(), inputField.text.ToString());
            AnswerText answerText = canvas.GetComponent<AnswerText>();
            answerText.Refresh();
        }
        inputField.Select();
        inputField.text = "";
    }
}
