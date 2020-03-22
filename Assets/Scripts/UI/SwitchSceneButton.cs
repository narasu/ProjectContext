using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneButton : UIButton
{
    [SerializeField] private string sceneToLoad;
    public int questionKey;
    protected override void TaskOnClick()
    {
        InputStorage.selectedQuestion = questionKey; 
        SceneManager.LoadScene(sceneToLoad);
    }
}
