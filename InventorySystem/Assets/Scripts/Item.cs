using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    #region variables
    /*
     * We will be creating variable to hold information for each of our
     * items. The data we will hold will be, The item's id. Title, aka
     * name of item. The discription explaining the item. A variable to
     * hold the image and lastly a dicsonary to hold it all in.
     */

    public int id;
    public string title;
    public string description;
    public Sprite icon;
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    #endregion

    #region Item Method
    /*
     * Since we are creating multiple items, we will be creating a method
     * that will create an item for us. All we must do is pass through the
     * parameters and it will create the item for us.
     * This is linking the items data to a space within the dictionary. 
     */

    public Item(int id, string title, string description, Dictionary<string, int> stats)
    {
        this.id = id;
        this.title = title;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + title);
        this.stats = stats;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + item.title);
        this.stats = item.stats;
    }
    #endregion
}
