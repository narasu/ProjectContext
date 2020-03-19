using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneButton : UIButton
{
    [SerializeField] private string sceneToLoad;
    protected override void TaskOnClick()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
