using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NotifButton : UIButton
{
    public string target;
    protected override void TaskOnClick()
    {
        SceneManager.LoadScene(target);
    }
}
