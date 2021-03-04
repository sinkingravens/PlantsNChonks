using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarEssentials : MonoBehaviour
{
    [Header("List and information")]
    public List<GameObject> essentialItemHotbar = new List<GameObject>();
    public int itemSpace;
    public int itemCurrent;


    [Header("Keycode")]
    public KeyCode switchUp;
    public KeyCode switchDown;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
