using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalWizard : MonoBehaviour
{
    int min;
    int max;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }

    void startGame()
    {
        min = 1;
        max = 1000;
        guess = 500;

        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log("You hit enter");
            startGame();
        }


    }
    void NextGuess()
    {
        guess = (min + max) / 2;
    }
}
