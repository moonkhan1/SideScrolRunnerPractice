using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _spawnerPrefab;

    [SerializeField] float _spawnerTime = 3.5f;
    [SerializeField] int _maxCount = 6;
    [SerializeField] int count = 0;
    Vector3 enemySpawn;

    public PlayerController _player;
    void Start()
    {
         StartCoroutine(spawnEnemy(_spawnerTime, _spawnerPrefab));
    }

    // Update is called once per frame
    void Update()
    {
        // float enemyX = Random.Range(-10f,10);
        // float enemyY = Random.Range(-6f,6f);
        // enemySpawn = _player.transform.position + new Vector3(enemyX,0,0);
    }

    IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        if (_maxCount > count)
        {
            yield return new WaitForSeconds(interval);
            GameObject newEnemy = Instantiate(enemy,(_player.transform.position + new Vector3(Random.Range(5f,15),0, 0)),Quaternion.identity);
            StartCoroutine(spawnEnemy(interval, enemy));
            count++;
        }
    }
}
