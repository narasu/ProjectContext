using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftButton : ArrowButton
{
    protected override void TaskOnClick()
    {
        itemSelection.Previous();
    }
}
