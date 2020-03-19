using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostAnswerButton : UIButton
{
    [SerializeField] private Text inputText;
    [SerializeField] private string question;
    [SerializeField][Tooltip("0 for question, 1 for answer")] private int queryType;

    protected override void Start()
    {
        base.Start();

    }

    protected override void TaskOnClick()
    {
        
    }
}
