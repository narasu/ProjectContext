using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpvoteButton : UIButton
{

    
    protected override void TaskOnClick()
    {
        Color c = new Color(155, 215, 148);
        Color c2 = new Color(0, 0, 0);

        ColorBlock cb = button.colors;

        cb.normalColor = c;

        GetComponent<Image>().color = c;
        button.colors = cb;
        
        Debug.Log(GetComponent<Image>().color);
        Debug.Log("clicked!");
    }
}
