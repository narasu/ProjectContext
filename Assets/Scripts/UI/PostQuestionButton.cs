using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostQuestionButton : UIButton
{
    [SerializeField] private InputField inputField;
    [SerializeField] private Canvas canvas;
    [SerializeField] private Font font;

    protected override void Start()
    {
        base.Start();
    }

    protected override void TaskOnClick()
    {
        if (inputField.text != "")
        {
            InputStorage.WriteQuestion(inputField.text.ToString());

            NotifTimer.asked = true;

            GameObject txtObj = new GameObject();
            txtObj.transform.parent = canvas.transform;
            txtObj.transform.localScale = new Vector3(1, 1, 1);
            txtObj.AddComponent<Text>();

            Text text = txtObj.GetComponent<Text>();
            text.font = font;
            text.text = "Je vraag is gesteld!";
            text.fontSize = 72;
            text.alignment = TextAnchor.MiddleCenter;

            RectTransform rectTransform;
            rectTransform = text.GetComponent<RectTransform>();
            rectTransform.localPosition = new Vector3(0, 0, 0);
            rectTransform.sizeDelta = new Vector2(600, 200);

        }

        

        inputField.Select();
        inputField.text = "";
    }
}
