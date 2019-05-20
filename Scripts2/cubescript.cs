using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This script is for player controll
 * Ready Joystick controller is used 
 */
public class cubescript : MonoBehaviour
{
    protected Joystick joystick;

    protected JumpButton jumpbutton;

    public int score;

    public GameObject Plane;

    private bool isgrounded;

    public Queue<Vector3> positions = new Queue<Vector3>();

    private Rigidbody rigidbodyy;
    private void Start()
    {
        this.joystick = UnityEngine.Object.FindObjectOfType<Joystick>();
    }

    private void Update()
    {
        this.rigidbodyy = base.GetComponent<Rigidbody>();
        this.rigidbodyy.velocity = new Vector3(this.joystick.Horizontal * 15f, this.rigidbodyy.velocity.y, this.joystick.Vertical * 15f);
        PlayerPrefs.SetInt("points", this.score);
    }
    //To do jumping
    public void jummp()
    {
        if (this.isgrounded)
        {
            this.rigidbodyy.velocity += Vector3.up * 16f;
        }
    }

    public void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Plane")
        {
            this.isgrounded = true;
        }
    }

    public void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Plane")
        {
            this.isgrounded = false;
        }
    }

    
}
