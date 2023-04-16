using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Zooming")]
    public Camera GodView;
    private float baseView = 60f;

    [Header("Movement")]
    [SerializeField] private KeyCode moveyy = KeyCode.Mouse1;

    [Header("Cursor")]
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Start()
    {
        
        GodView.fieldOfView = baseView;
    } 
    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
        {
            GodView.fieldOfView += 10f;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0) // backwards
        {
            GodView.fieldOfView -= 10f;
        }

        GodView.fieldOfView = Mathf.Clamp
        (GodView.fieldOfView + Input.GetAxis("Mouse ScrollWheel"), 30f, 90f);

    }


    private void canMove()
    {
        if (Input.GetKeyDown(moveyy))
        {

        }
    }
}
