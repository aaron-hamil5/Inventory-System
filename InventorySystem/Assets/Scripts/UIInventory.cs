using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    #region Variables
    //Linking the UIitem
    public List<UIItem> uiItems = new List<UIItem>();
    //This is to populate it with the slot
    public GameObject slotPrefab;
    //This is the location the slot is at
    public Transform slotPanel;
    #endregion

    #region Awake
    void Awake()
    {
        //Will create 24 new slots
        for (int i = 0; i < 24; i++)
        {
            //Create a new slot
            GameObject instance = Instantiate(slotPrefab);
            //Tell The location of the inventory
            instance.transform.SetParent(slotPanel);
            //Add the Item from the UIScript
            uiItems.Add(instance.GetComponentInChildren<UIItem>());
        }
    }
    #endregion
}
