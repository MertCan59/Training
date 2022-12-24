using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject [] enemy;

  void Start()
    {
        InvokeRepeating("Spawn", 3f, 3f);
    }
    void Spawn()
    {
        Vector3 randomSpawnLocation = new Vector3(Random.Range(-17f, 30f), 1f, Random.Range(-30f, 17f));
        for(int i = 0; i < enemy.Length; i++)
        {
            Instantiate(enemy[i], randomSpawnLocation, Quaternion.identity);
        }
    }

}
