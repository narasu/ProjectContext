using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : ArrowButton
{
    
    protected override void TaskOnClick()
    {
        itemSelection.Next();
    }
}
