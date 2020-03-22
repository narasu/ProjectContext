using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoQuestionButton : UIButton
{
    
    protected override void TaskOnClick()
    {
        
        SceneManager.LoadScene("Question");
    }
}
