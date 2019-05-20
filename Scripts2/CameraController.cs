using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private void Start()
    {
        this.offset = base.transform.position - this.player.transform.position;
    }

    private void LateUpdate()
    {
        base.transform.position = this.player.transform.position + this.offset;
    }

    public GameObject player;

    private Vector3 offset;
}
