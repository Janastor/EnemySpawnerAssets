using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    private Vector2 _spawnDirection;
    
    private void Start()
    {
        float angleInRadians = transform.rotation.eulerAngles.z * Mathf.Deg2Rad;
        _spawnDirection = new Vector2(Mathf.Cos(angleInRadians), Mathf.Sin(angleInRadians));
    }

    public void SpawnEnemy(Enemy enemyPrefab)
    {
        Enemy spawned = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        spawned.Init(_spawnDirection);
    }
}
