using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int currentTimeIG = 0; // Shows the time inGame

    private float currentTimePriv;

    void Start()
    {
        
    }

    void Update()
    {
        //currentTimePriv is always equal to Time.Delta time
        currentTimePriv += Time.deltaTime;

        //Until currenTimePriv = 1
        if(currentTimePriv > 1)
        {
            //Then it will add a second to IG time and reset it to zero
            currentTimeIG += 1;
            currentTimePriv = 0;
        }
            
    }
}
