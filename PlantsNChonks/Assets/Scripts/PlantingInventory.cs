using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantingInventory : MonoBehaviour
{
    public KeyCode useKey = KeyCode.Mouse0;
    public KeyCode switchRight = KeyCode.E;
    public KeyCode switchLeft = KeyCode.Q;
    //public GameObject plant;

    [Header("Inventory for Plants")]
    public List<GameObject> typeOfPlants = new List<GameObject>();
    public Transform plantTransform;
    public int plantSpace = 2;
    public int plantCurrent = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InventorySeeds();
        useCurrentPlant();

    }

    public void InventorySeeds()
    {
        //if input is switchRight switch plantSeed to another.
        if (Input.GetKeyDown(switchRight))
        {
            plantCurrent += 1;
            Debug.Log("The inventory number is currently " + plantCurrent + ".");
            //if plantcurrent is greater than plantspace, reset it
            if (plantCurrent > plantSpace)
            {
                plantCurrent = 1;
                Debug.Log("Inventory is reset and the current number is" + plantCurrent.ToString());

            }
            
        }

        //if input is switchLeft switch plantSeed to another.
        if (Input.GetKeyDown(switchLeft))
        {
            plantCurrent -= 1;
            Debug.Log("The inventory number is currently " + plantCurrent + ".");
            //if plantcurrent is less or equal to zero reset it to the largest number
            if (plantCurrent == 0)
            {
                plantCurrent = plantSpace;
                Debug.Log("Inventory is reset and the current number is" + plantCurrent.ToString());
            }
            
        }
    }

    public void useCurrentPlant()
    {
        //if input is usekey, plant the current plant.
        if (Input.GetKeyDown(useKey))
        {
            Instantiate(typeOfPlants[plantCurrent - 1], transform.position, transform.rotation);
        }
    }
}
