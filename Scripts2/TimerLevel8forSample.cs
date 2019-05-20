using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerLevel8forSample : MonoBehaviour
{
    public Text timerText8;

    public Text finalTime8;

    public Text bestTime8;

    private float startTime;

    private bool finished = true;

    private float t;
    private void Start()
    {
        this.startTime = Time.time;
        //Shows previous best score at the top-left
        if (PlayerPrefs.HasKey("HighScore8"))
        {
            this.bestTime8.text = "Best: " + PlayerPrefs.GetFloat("HighScore8").ToString("f2");
        }
    }

    private void Update()
    {
        //Lines for timer 
        if (this.finished)
        {
            return;
        }
        this.t = Time.time - this.startTime;
        string str = ((int)this.t / 60).ToString();
        string str2 = (this.t % 60f).ToString("f2");
        this.timerText8.text = str + ":" + str2;
        PlayerPrefs.SetFloat("Score8", this.t);
    }

    public void FinishL8()
    {
        //Script inside invisible box at the end calls this function to stop and set time
        this.finished = true;
        this.timerText8.color = Color.green;
        float @float = PlayerPrefs.GetFloat("Score8");
        this.finalTime8.text = "Time: " + @float.ToString("f2");
        this.GameFinished();
    }

    public void Finish2()
    {
        this.startTime = Time.time;
    }

    public void StartRoll()
    {
        this.finished = false;
        this.startTime = Time.time;
    }

    private void GameFinished()
    {
        //Setting high score and best as well
        float num = Time.time - this.startTime;
        if (num < PlayerPrefs.GetFloat("HighScore8", 3.40282347E+38f))
        {
            PlayerPrefs.SetFloat("HighScore8", num);
            this.bestTime8.text = num.ToString("f2");
            PlayerPrefs.Save();
        }
    }

    
}
