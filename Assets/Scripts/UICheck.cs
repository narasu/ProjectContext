using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICheck : MonoBehaviour
{
    [SerializeField] private GameObject uiCanvas;
    [SerializeField] private Camera cam;
    private void Awake()
    {
        if (!InputStorage.firstTimeStartup)
        {
            GameObject go = Instantiate(uiCanvas);
            Canvas c = go.GetComponent<Canvas>();
            c.worldCamera = cam;
        }
    }
}
