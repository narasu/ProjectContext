using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostQuestionButton : UIButton
{
    [SerializeField] private InputField inputField;


    protected override void Start()
    {
        base.Start();
    }

    protected override void TaskOnClick()
    {
        if (inputField.text != "")
        {
            InputStorage.WriteQuestion(inputField.text.ToString());
        }
        inputField.Select();
        inputField.text = "";
    }
}
