using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;

    public int platformCount = 1000;

    void Start()
    {
        Vector3 spawnPostion = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPostion.y += Random.Range(.5f, 2f);
            spawnPostion.x = Random.Range(-5f, 5f);
            Instantiate(platformPrefab, spawnPostion, Quaternion.identity);
        }
    }
}
