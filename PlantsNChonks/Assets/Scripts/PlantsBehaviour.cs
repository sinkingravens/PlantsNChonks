using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantsBehaviour : MonoBehaviour
{
    public bool isHarvestable = false;
    
    //Clock
    [SerializeField] private float plantTime;
    [SerializeField] private int timeUntilHarvestable = 10; // Time until the plant is harvestable

    // Update is called once per frame
    void Update()
    {
        plantTimer();
        canHarvest();

    }

    public void canHarvest()
    {
        if(timeUntilHarvestable == 0) //if timeUntilHarvestable is 0 then isHarvestabe = true;
        {
            isHarvestable = true;
        }
    }

    public void plantTimer()
    {
        //if harvestable is false, continue the timer
        if (isHarvestable == false)
        {
            plantTime += Time.deltaTime;
            if (plantTime > 1) // if planttime is more than one, timeUntilHarvest will be one second less and plantTime will reset
            {
                timeUntilHarvestable -= 1;
                plantTime = 0;
            }
        }
    }
}
