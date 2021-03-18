using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [Header("Inventory Items")]
    [SerializeField] private List<GameObject> typeOfTools = new List<GameObject>();
    [SerializeField] private int itemCurrent;
    [SerializeField] private int itemSpace;
    [SerializeField] private Transform itemHolder;

    void Start()
    {
        
    }

    void Update()
    {
        inventoryItem();
    }

    public void inventoryItem()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f) //Updates the item when you scroll up
        {
            itemCurrent += 1;
            if(itemCurrent > itemSpace)
            {
                itemCurrent = 1;
                
                if(itemHolder.childCount > 0)
                {
                    GameObject item = itemHolder.GetChild(0).gameObject;
                    Destroy(item);

                }
                Instantiate(typeOfTools[itemCurrent - 1], itemHolder);
            }
            else
            {
                if (itemHolder.childCount > 0)
                {
                    GameObject item = itemHolder.GetChild(0).gameObject;
                    Destroy(item);
                }
                Instantiate(typeOfTools[itemCurrent - 1], itemHolder);
            }
        }

        if(Input.GetAxis("Mouse ScrollWheel") < 0f) // Updates when you scroll down
        {
            itemCurrent -= 1;
            if(itemCurrent == 0)
            {
                itemCurrent = itemSpace;

                if (itemHolder.childCount > 0)
                {
                    GameObject item = itemHolder.GetChild(0).gameObject;
                    Destroy(item);
                }
                Instantiate(typeOfTools[itemCurrent - 1], itemHolder);

            }
            else
            {
                if (itemHolder.childCount > 0)
                {
                    GameObject item = itemHolder.GetChild(0).gameObject;
                    Destroy(item);
                }
                Instantiate(typeOfTools[itemCurrent - 1], itemHolder);
            }

        }
    }
}
