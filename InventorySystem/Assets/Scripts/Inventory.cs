using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Varables
    //We will be needing to link the other scipts to this.
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;
    #endregion

    #region Getting the item by ID Method
    //We will get the ID of the item and then add it to the players inventory
    public void GiveItem(int id)
    {
        //Finding the item by ID we created in the itemDatabase script
        Item itemToAdd = itemDatabase.GetItem(id);
        //Adding the item to the Inventory
        characterItems.Add(itemToAdd);
        //Display a log of the item, Including the name so we know what the item is
        Debug.Log("Added item: " + itemToAdd.title);
    }
    #endregion

    #region Geting the item by title method
    //We will be creating the same code, but insted of finding it by the ID
    //We will find the item by the name instead
    public void GiveItem(string itemName)
    {
        Item itemToAdd = itemDatabase.GetItem(itemName);
        characterItems.Add(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }
    #endregion
}
