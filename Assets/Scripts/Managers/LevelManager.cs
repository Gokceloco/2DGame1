using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform mainCameraTransform;
    public List<LevelParent> levelPrefabs;
    public void StageCompleted()
    {
        var newLevel = Instantiate(levelPrefabs[0]);
        newLevel.transform.position = new Vector3 (0, 10, 0);
        mainCameraTransform.position = new Vector3(0, 10, -10);
    }
}
