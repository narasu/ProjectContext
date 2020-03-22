using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsList : MonoBehaviour
{
    
    [SerializeField] [Tooltip("0 for user question, 1 for other")] private int type;
    [SerializeField] private GameObject questionButton;

    private List<string> questions;
    private List<GameObject> txtObjList;

    private float yPos = 400f;


    private void Awake()
    {
        txtObjList = new List<GameObject>();

        questions = InputStorage.GetQuestionsList(type);
        InputStorage.selectedType = type;
        Refresh();
    }

    public void Refresh()
    {
        float y = yPos;

        foreach (GameObject go in txtObjList)
        {
            Destroy(go);
        }
        txtObjList.Clear();


        for (int i = 0; i < questions.Count; i++)
        {

            GameObject qb = Instantiate(questionButton) as GameObject;
            txtObjList.Add(qb);
            txtObjList[i].transform.SetParent(gameObject.transform);
            txtObjList[i].transform.localScale = new Vector3(1, 1, 1);

            Text text = txtObjList[i].GetComponentInChildren<Text>();
            text.text = questions[i];
            text.fontSize = 48;
            text.alignment = TextAnchor.UpperCenter;

            RectTransform rectTransform;
            rectTransform = txtObjList[i].GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0, y);
            rectTransform.sizeDelta = new Vector2(600, text.preferredHeight+30f);

            SwitchSceneButton ssb = txtObjList[i].GetComponent<SwitchSceneButton>();
            ssb.questionKey = i;

            y -= rectTransform.sizeDelta.y + text.preferredHeight;
        }
    }
}
