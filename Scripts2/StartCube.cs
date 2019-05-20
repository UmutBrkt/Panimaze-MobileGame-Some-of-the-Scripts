using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCube : MonoBehaviour
{
    //when player enters it's collision this script sends message to start timer 
    public void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Sphere").SendMessage("StartRoll");
    }
}
