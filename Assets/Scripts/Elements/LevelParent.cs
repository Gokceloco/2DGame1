using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelParent : MonoBehaviour
{
    private GameDirector _gameDirector;

    public List<Enemy> enemies;

    public void StartLevel(GameDirector gameDirector)
    {
        _gameDirector = gameDirector;
        foreach (Enemy enemy in enemies)
        {
            enemy.StartEnemy(gameDirector);
        }
    }
}
