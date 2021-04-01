using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{
    #region Variables
    //Link the Item Scripy
    public Item item;
    //Used for changing the image
    private Image spriteImage;
    #endregion

    #region GAwake
    //Once the slot appears it will isnstenly get the Image
    void Awake()
    {
        spriteImage = GetComponent<Image>();
        //Making sure we have an empty slot
        UpdateItem(null);
    }
    #endregion

    #region Check if theres an item
    public void UpdateItem(Item item)
    {
        //get the item
        this.item = item;
        if (this.item != null)
        {
            //It will get the image and load it
            spriteImage.color = Color.white;
            spriteImage.sprite = item.icon;
        }
        else
        {
            //If theres nothing then it will be clear
            spriteImage.color = Color.clear;
        }
    }
    #endregion
}
