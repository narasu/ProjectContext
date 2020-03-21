﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerText : MonoBehaviour
{
    [SerializeField] private Text question;
    [SerializeField] private int type;
    [SerializeField] private Font font;
    [SerializeField] private GameObject answerField;

    private List<string> answers;
    private List<GameObject> txtObjList;
    private List<GameObject> fieldList;

    private float yPos = 300f;

    Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        txtObjList = new List<GameObject>();
        fieldList = new List<GameObject>();

        answers = InputStorage.GetAnswers(type, question.text.ToString());
        Refresh();
    }

    public void Refresh()
    {
        yPos = 240f;

        foreach (GameObject go in txtObjList)
        {
            Destroy(go);
        }
        txtObjList.Clear();

        foreach (GameObject go in fieldList)
        {
            Destroy(go);
        }
        fieldList.Clear();

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

            GameObject field = Instantiate(answerField) as GameObject;
            Vector3 fieldOffset = new Vector3(0, 0.3f);
            field.transform.position = rectTransform.position + fieldOffset;
            
            fieldList.Add(field);
            
            yPos -= 155f;
        }
    }

}
