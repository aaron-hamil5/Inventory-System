using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    #region Variables
    //We will create a list to hold all of the items we have in the game.
    public List<Item> items = new List<Item>();
    #endregion

    void Awake()
    {
        BuildDatabase();
    }

    #region Database builder
    //We will create a database with all of the items and populate them will data.
    void BuildDatabase()
    {
        items = new List<Item>() {
            #region Sword
            //ID, Name, Description
            new Item(0, "Diamond Sword", "A sword made of diamond.",
            //Power, Defence
            new Dictionary<string, int> {{ "Power", 15 }, { "Defence", 10 }}),
            #endregion

            #region Ore
            new Item(1, "Diamond Ore", "A pretty diamond.",
            new Dictionary<string, int> {{ "Value", 300 } }),
            #endregion

            #region Pick
            new Item(2, "Silver Pick", "A pick that could kill avampire.",
            new Dictionary<string, int> {{ "Power", 5 },{ "Mining", 20}})};
            #endregion
    }
    #endregion

    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }
    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

}
