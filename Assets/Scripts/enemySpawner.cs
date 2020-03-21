using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour {
    public float delay;
    public GameObject enemy;

    void Start() {
        InvokeRepeating("SpawnEnemy", 0.0f, delay);
    }

    void SpawnEnemy() {
        int randomPos = (int)Random.Range(0, transform.childCount);
        Instantiate(enemy, transform.GetChild(randomPos).position, enemy.transform.rotation);
    }
}
