using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guessNumber : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (min + max) / 2;
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (min + max) / 2;
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log("You hit enter");
        }

    }
}
