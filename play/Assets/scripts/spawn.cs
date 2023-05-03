using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spawn : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject Player;
    public int maxEnemy = 5;

    public float timeSpawn = 2f;
    private float timer;

    public float distance = 3;

    private void Start()
    {
        timer = timeSpawn;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeSpawn;
            if (transform.childCount < maxEnemy)
            {
                var instance = Instantiate(EnemyPrefab, transform.position, Quaternion.identity, transform);
                instance.GetComponent<zombie>().Player = Player;
            }
        }
    }
}
