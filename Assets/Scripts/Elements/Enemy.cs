using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameDirector _gameDirector;

    public EnemyBullet enemyBulletPrefab;

    public void StartEnemy(GameDirector gameDirector)
    {
        _gameDirector = gameDirector;
        StartCoroutine(SpawnBulletCoroutine());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().GetHit();
        }
    }
    public void GetHit()
    {
        gameObject.SetActive(false);
        _gameDirector.fxManager.PlayEnemyDestroyParticles(transform.position);
    }

    IEnumerator SpawnBulletCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            SpawnBullet();
        }
    }

    private void SpawnBullet()
    {
        var newBullet = Instantiate(enemyBulletPrefab);
        newBullet.transform.position = transform.position;
        newBullet.StartBullet();
    }
}
