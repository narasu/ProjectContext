using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerText : MonoBehaviour
{
    [SerializeField] private Text question;
    [SerializeField] private int type;
    [SerializeField] private Font font;
    private List<string> answers;
    private List<GameObject> txtObjList;

    private float yPos = 0f;

    Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        txtObjList = new List<GameObject>();

        answers = InputStorage.GetAnswers(type, question.text.ToString());
        Refresh();
    }

    public void Refresh()
    {
        yPos = 0f;

        foreach (GameObject go in txtObjList)
        {
            Destroy(go);
        }
        txtObjList.Clear();
        
        for (int i = 0; i < answers.Count; i++)
        {
            txtObjList.Add(new GameObject());
            txtObjList[i].transform.parent = gameObject.transform;
            txtObjList[i].transform.localScale = new Vector3(1, 1, 1);
            txtObjList[i].AddComponent<Text>();

            Text text = txtObjList[i].GetComponent<Text>();
            text.font = font;
            text.text = answers[i];
            text.fontSize = 48;
            text.alignment = TextAnchor.UpperLeft;

            RectTransform rectTransform;
            rectTransform = text.GetComponent<RectTransform>();
            rectTransform.localPosition = new Vector3(0, yPos, 0);
            rectTransform.sizeDelta = new Vector2(600, 200);

            yPos -= 100;
        }
    }

}
