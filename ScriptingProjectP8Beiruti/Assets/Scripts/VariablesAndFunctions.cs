using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    // Create a variable of type integer
    int myInt = 24;


    // Start is called before the first frame update
    void Start()
    {
        // I am going to run myInt thru my function to multiply it by 2
        myInt = MultiplyByTwo(myInt);

        // Im going to print the results to the console
        Debug.Log(myInt);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Creating a function that takes an int paramter and multiplies it by 2
    int MultiplyByTwo(int number)
    {
        // creating a variable to store my results
        int results;
        // multiplying the passed paramater by 2
        results = number * 2;

        // returning the results
        return results;
    }

}
