using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Player player;

    private bool _areControlsActive;
    public void StartInputManager()
    {
        _areControlsActive = true;
    }
    private void Update()
    {
        if (_areControlsActive)
        {
            if (Input.GetKey(KeyCode.A))
            {
                player.MoveLeft();
            }
            if (Input.GetKey(KeyCode.D))
            {
                player.MoveRight();
            }
            if (Input.GetKeyDown(KeyCode.Space) && player.IsTouchingGround())
            {
                player.Jump();
            }
            if (Input.GetMouseButtonDown(0))
            {
                player.Attack();
            }
        }
    }
}
