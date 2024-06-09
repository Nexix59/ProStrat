using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool _CanMove;
    public float _ScrollSpeed;
    public float _Drag_Speed;
    KeyCode _Camera_Drag_Key = KeyCode.Mouse2;
    Vector3 _Origin;
    void Update()
    {
        if (_CanMove) _Cam_Movement();
    }

    void _Cam_Movement()
    {
        if (Input.GetKeyDown(_Camera_Drag_Key))
            _Origin = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKey(_Camera_Drag_Key))
            transform.position += (_Origin - GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition)) * _Drag_Speed;

        if (Input.mouseScrollDelta == new Vector2(0, 1) && GetComponent<Camera>().orthographicSize >= 100)
            GetComponent<Camera>().orthographicSize += -Input.mouseScrollDelta.y * _ScrollSpeed;
        if (Input.mouseScrollDelta == new Vector2(0, -1) && GetComponent<Camera>().orthographicSize <= 4000)
            GetComponent<Camera>().orthographicSize += -Input.mouseScrollDelta.y * _ScrollSpeed;
    }
}
