using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneButton : UIButton
{
    public string sceneToLoad;
    public int type;
    public int questionKey;
    protected override void TaskOnClick()
    {
        InputStorage.selectedType = type;
        InputStorage.selectedQuestion = questionKey; 
        SceneManager.LoadScene(sceneToLoad);
    }

}
