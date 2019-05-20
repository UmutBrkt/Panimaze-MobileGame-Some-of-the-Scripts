using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public Levels(int id, string levelname, bool completed, int starts, bool locked)
    {
        this.ID = id;
        this.LevelName = levelname;
        this.Completed = completed;
        this.Starts = starts;
        this.Locked = locked;
    }

    public int ID { get; set; }

    public string LevelName { get; set; }

    public bool Completed { get; set; }

    public int Starts { get; set; }

    public bool Locked { get; set; }

    public void Complete()
    {
        this.Completed = true;
    }

    public void Complete(int starts)
    {
        this.Completed = true;
        this.Starts = starts;
    }

    public void Lock()
    {
        this.Locked = true;
    }

    public void Unlock()
    {
        this.Locked = false;
    }
}
