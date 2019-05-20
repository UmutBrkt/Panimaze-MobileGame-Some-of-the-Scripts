using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class VariableJoystick : MonoBehaviour
{
    //This script is a ready to use script came with joystick from assetstore
    [Header("Variable Joystick Options")]
    public bool isFixed = true;

    public Vector2 fixedScreenPosition;

    private Vector2 joystickCenter = Vector2.zero;
    private void Start()
    {
        if (this.isFixed)
        {
            this.OnFixed();
        }
        else
        {
            this.OnFloat();
        }
    }

    public void ChangeFixed(bool joystickFixed)
    {
        if (joystickFixed)
        {
            this.OnFixed();
        }
        else
        {
            this.OnFloat();
        }
        this.isFixed = joystickFixed;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        Vector2 a = eventData.position - this.joystickCenter;
        this.inputVector = ((a.magnitude <= this.background.sizeDelta.x / 2f) ? (a / (this.background.sizeDelta.x / 2f)) : a.normalized);
        base.ClampJoystick();
        this.handle.anchoredPosition = this.inputVector * this.background.sizeDelta.x / 2f * this.handleLimit;
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        if (!this.isFixed)
        {
            this.background.gameObject.SetActive(true);
            this.background.position = eventData.position;
            this.handle.anchoredPosition = Vector2.zero;
            this.joystickCenter = eventData.position;
        }
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        if (!this.isFixed)
        {
            this.background.gameObject.SetActive(false);
        }
        this.inputVector = Vector2.zero;
        this.handle.anchoredPosition = Vector2.zero;
    }

    private void OnFixed()
    {
        this.joystickCenter = this.fixedScreenPosition;
        this.background.gameObject.SetActive(true);
        this.handle.anchoredPosition = Vector2.zero;
        this.background.anchoredPosition = this.fixedScreenPosition;
    }

    private void OnFloat()
    {
        this.handle.anchoredPosition = Vector2.zero;
        this.background.gameObject.SetActive(false);
    }

    
}
