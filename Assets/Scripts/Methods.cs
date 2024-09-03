using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    //    First Assignment:


    void Start()
    {
        OperatorMethod(3);

        IfMethod(3, 5);
        IfMethod(8, 5);

        SwitchMethod(1);
        SwitchMethod(2);
        SwitchMethod(3);
        SwitchMethod(4);

    }

    // Create a method that accepts an integer, operates it and prints out the result.
    public void OperatorMethod(int num)
    {
        num++;
        Debug.Log($"result: {num}");

    }

    // Create a method that accepts an integer, with an if statement about this integer.
    public void IfMethod(int num, int threshold)
    {
        if (num > threshold)
        {
            Debug.Log($"number is greater than {threshold}");
            // Print something inside the if body,
        }

        else
        {
            Debug.Log($"number is less than {threshold}");

        }
        // and inside the else body.

    }
    // Create a method that accepts an integer, with a switch statement with 3 cases about this integer.Print something in the cases.
    public void SwitchMethod(int num)
    {
        switch (num)
        {
            case (1):
                Debug.Log($"case 1");
                break;

            case (2):
                Debug.Log($"case 2");

                break;

            case (3):
                Debug.Log($"case 3");

                break;

            default:
                Debug.Log("Invalid Input!");

                break;
        }

    }



}
