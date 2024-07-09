using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxManager : MonoBehaviour
{
    public ParticleSystem enemyDestroyParticlesPrefab;

    public void PlayEnemyDestroyParticles(Vector3 pos)
    {
        var newFX = Instantiate(enemyDestroyParticlesPrefab);
        newFX.transform.position = pos;
        newFX.Play();
    }
}
