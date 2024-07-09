using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public InputManager inputManager;
    public LevelManager levelManager;
    public FxManager fxManager;

    public LevelParent levelParent;
    void Start()
    {
        StartGame();
    }
    private void StartGame()
    {
        inputManager.StartInputManager();
        levelParent.StartLevel(this);
    }
}
