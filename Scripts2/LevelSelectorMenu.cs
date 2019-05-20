using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelectorMenu : MonoBehaviour
{
    public SceneManager scene;

    public Button[] levelButtons;
    private void Start()
    {
        //to enable and disable level buttons
        int @int = PlayerPrefs.GetInt("levelReached", 1);
        for (int i = 0; i < this.levelButtons.Length; i++)
        {
            if (i + 1 > @int)
            {
                this.levelButtons[i].interactable = false;
                this.levelButtons[i].image.color = Color.red;
            }
        }
    }
    //loads chosen scene and starts the game
    public void SelectScene(int levelName)
    {
        SceneManager.LoadScene(levelName);
        Time.timeScale = 1f;
    }

    
}
