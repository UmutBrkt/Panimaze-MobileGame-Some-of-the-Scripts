using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject ui;

    public bool paused;
    private void Start()
    {
        this.paused = false;
    }

    public void Toggle() //When button clicked it pauses time and show the pause menu canvas
    {
        this.paused = true;
        Time.timeScale = 0f;
        this.ui.SetActive(!this.ui.activeSelf);
    }

    
}
