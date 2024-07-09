using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private bool _isBulletStarted;

    public float speed;
    public void StartBullet()
    {
        _isBulletStarted = true;
    }

    private void Update()
    {
        if (_isBulletStarted)
        {
            transform.position = transform.position + Vector3.left * Time.deltaTime * speed;
        }
    }
}
