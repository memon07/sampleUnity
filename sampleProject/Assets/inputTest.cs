using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int min = 0;
        int max = 999;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            Debug.Log("Up arrow was pressed");

        if (Input.GetKeyDown(KeyCode.DownArrow))
            Debug.Log("Up down was pressed");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("You hit enter");
    }
}
