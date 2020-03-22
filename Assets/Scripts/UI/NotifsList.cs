using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotifsList : MonoBehaviour
{
    [SerializeField] private GameObject notifButton;

    
    private List<GameObject> txtObjList;

    private WaitForSeconds refreshTime = new WaitForSeconds(2f);

    private float yPos = 400f;


    private void Awake()
    {
        txtObjList = new List<GameObject>();
        StartCoroutine(Refresh());
        //Refresh();
    }

    private IEnumerator Refresh()
    {
        float y = yPos;

        foreach (GameObject go in txtObjList)
        {
            Destroy(go);
        }
        txtObjList.Clear();


        for (int i = 0; i < Notifications.notifContent.Count; i++)
        {

            GameObject qb = Instantiate(notifButton) as GameObject;
            txtObjList.Add(qb);
            txtObjList[i].transform.SetParent(gameObject.transform);
            txtObjList[i].transform.localScale = new Vector3(1, 1, 1);

            SwitchSceneButton ssb = qb.GetComponent<SwitchSceneButton>();
            ssb.sceneToLoad = Notifications.notifTarget[i];

            Text text = txtObjList[i].GetComponentInChildren<Text>();
            text.text = Notifications.notifContent[i];
            text.fontSize = 48;
            text.alignment = TextAnchor.MiddleCenter;

            RectTransform rectTransform;
            rectTransform = txtObjList[i].GetComponent<RectTransform>();
            rectTransform.anchoredPosition = new Vector2(0, y);
            rectTransform.sizeDelta = new Vector2(600, text.preferredHeight + 30f);

            y -= rectTransform.sizeDelta.y + text.preferredHeight;
        }
        yield return refreshTime;
    }
}
