using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maximum_number;
    int minimum_number;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maximum_number = 1000;
        minimum_number = 1;
        guess = NextGuessValue();

        Debug.Log("Starting Number Wizard!");
        Debug.Log("Please think of a number between " + minimum_number + " " +
            "and " + maximum_number);
        Debug.Log("Is you number higher or lower than " + guess);
        Debug.Log("Push up if higher; Push down if lower; Push enter if correct.");
        maximum_number += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minimum_number = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maximum_number = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Awesome! Figured it out!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = NextGuessValue();
        Debug.Log("Let me try again " + guess + " Higher or lower?");
    }

    int NextGuessValue()
    {
        return (maximum_number + minimum_number) / 2;
    }
}
