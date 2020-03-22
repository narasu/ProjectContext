using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SaveName : UIButton
{
    [SerializeField] private InputField username;
    private void Awake()
    {
        if (!InputStorage.firstTimeStartup)
        {
            Destroy(gameObject);
        }
    }

    protected override void TaskOnClick()
    {
        InputStorage.username = username.text;
        SceneManager.LoadScene("Main");
    }
}
