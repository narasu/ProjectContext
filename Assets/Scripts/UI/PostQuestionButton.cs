using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostQuestionButton : UIButton
{
    
    [SerializeField] private Text inputText;
    [SerializeField] [Tooltip("0 for question, 1 for answer")] private int queryType;

    
    protected override void TaskOnClick()
    {
        InputStorage.WriteQuestion(inputText.text.ToString());
    }
}
