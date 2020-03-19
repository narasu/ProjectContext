using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class creates a list for items that can be selected, 
 * and cycles through the list when prompted by button presses. */
public class ItemSelection : MonoBehaviour
{
    private List<Sprite> itemList;
    
    private int currentIndex;

    [SerializeField]
    [Tooltip("Enter the exact folder name (starting from Resources/Character) for the type of item you wish to load")] 
    private string itemType; // type of item to load from resources folder

    [SerializeField] // set to 0 for hair, 1 for top, 2 for bottom, 3 for shoes
    private int typeIndex;

    private SpriteRenderer sr;

    //loads sprites of specified type from resources folder
    private void Awake()
    {
        itemList = new List<Sprite>();
        itemList.AddRange(Resources.LoadAll<Sprite>("Character/" + itemType));

        sr = GetComponent<SpriteRenderer>();
        sr.sprite = itemList[currentIndex];
    }

    //returns the currently active index
    public int GetIndex()
    {
        return currentIndex;
    }

    //go to previous item in the list
    public void Previous()
    {
        if (currentIndex > 0)
        {
            currentIndex--;
            sr.sprite = itemList[currentIndex];
            InputStorage.InsertIntoCharList(typeIndex, currentIndex);
            Debug.Log(InputStorage.ReadFromCharList(typeIndex));
        }
    }

    //go to next item in the list
    public void Next()
    {
        if (itemList.Count>currentIndex+1)
        {
            currentIndex++;
            sr.sprite = itemList[currentIndex];
            InputStorage.InsertIntoCharList(typeIndex, currentIndex);
            Debug.Log(InputStorage.ReadFromCharList(typeIndex));
        }
    }
}
