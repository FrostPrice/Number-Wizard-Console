using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start() // Only initiates once, when the application starts 
    {
        StartGame(); // You need to call a Function to use it, the () means that you're calling the Function
    }

    // The void keyword means that a function is NOT going to return a Value
    // To create a Function you can use the void keyword and then the name of the function, after the name () and then create a Declaration Block {}
    void StartGame() // Functions con be used as many times as you want, the () is the Parameters that you can put in the function
    {
        max = 1000;
        min = 1;
        guess = 500;

        // int max; // You can simply declare a variable and give the data later
        Debug.Log("Hello and welcome to Number Wizard!");    // Print and Debug are almost the same, but Debug give us more flexiblility
        Debug.Log("Choose a number, and keep it a secret...");
        Debug.Log("The Highest number you can pick is: " + max);
        Debug.Log("The Lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Instructions: Arrow Up = Higher, Arrow Down = Lower, Push Enter = Correct");

        max = max + 1; // You can assing a Variable to itself

        // Variable syntax: type name = data
        // Variables type, E.g. Integer (int) 10, float 5.4f, bool (true or false), string ("text")

    }

    // Update is called once per frame
    void Update() // It is called whenever something changes in a singular frame, Or when anything is need to have instant reaction in any point in time
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) // The if is seen first, and with it's condition is NOT meet, the else if or else block will try to tbe executed
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)) // The Return key is the Enter key
        {
            Debug.Log("It's correct ;)");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("The Value is higher or lower than..." + guess);
    }

    // Code Blocks {} creates scopes, which means that the code writen inside the Code Block is only acessible inside the same Code Block, the child element can get the variables inside it's parent element, this type o variable is called an Instance Variable
}