using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class FinishCube8forSample : MonoBehaviour
{
    public GameObject patlama; //this is for particle system

    public GameObject scorePanel; //Drag score panel here
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Sphere").SendMessage("FinishL8"); //calls function in level 8 timer script
        if (PlayerPrefs.GetInt("levelReached") < 9) //these lines are for unlocking next levels
        {
            PlayerPrefs.SetInt("levelReached", 9);
        }
        //Some of the levels don't have following lines to not disturp user withd ads after every level.
        UnityEngine.Object.Instantiate<GameObject>(this.patlama, base.gameObject.transform.position, base.gameObject.transform.rotation);
        this.scorePanel.SetActive(!this.scorePanel.activeSelf);
        if (UnityEngine.Advertisements.Advertisement.IsReady())
        {
            UnityEngine.Advertisements.Advertisement.Show("video");
        }
    }

    
}
