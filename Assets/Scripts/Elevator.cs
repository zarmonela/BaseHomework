using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
   private int currentFloor;

    void Start()
    {

        currentFloor = 0;
        FloorRequest(7);
        FloorRequest(2);
        FloorRequest(5);
        FloorRequest(99);
        FloorRequest(13);
    }
// amazing amazing architecture and great understanding of code reusability!
    public void FloorRequest(int floor)
    {
        Debug.Log($"current floor {currentFloor} | FLOOR REQUEST: {floor} ");
        MoveToFloor(currentFloor, floor);
        currentFloor = floor;
    }
    //Write methods for the elevator like: 
    public void MoveToFloor(int currentFloor, int requestedFloor)
    {
        if (currentFloor > requestedFloor)
        {
            int floorsToMove = currentFloor - requestedFloor;
            GoDown(floorsToMove);
        }
       
        if (currentFloor < requestedFloor)
        {
            int floorsToMove = requestedFloor - currentFloor;
            GoUp(floorsToMove);

        }

        else return; 
    }

    public void GoUp(int howMuchFloors)
    {
        Debug.Log($"elevator moves {howMuchFloors} floors up");

    }

    public void GoDown(int howMuchFloors)
    {
        Debug.Log($"elevator moves {howMuchFloors} floors down");
    }

}
