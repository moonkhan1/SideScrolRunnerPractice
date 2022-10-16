using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    // [SerializeField] Transform _player;
    GameObject Player;
    int _enemyDamage = 2;
    float _enemySpeed = 5f;

    [SerializeField] EnemyData _data;
    void Start()
    {
         Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Follow();
        SetEnemyStats();
    }

    void SetEnemyStats()
    {
        GetComponent<Health>().SetHealth(_data.HP,_data.HP);
        _enemyDamage = _data.damage;
        _enemySpeed = _data.speed;
    }

    private void Follow()
    {
        transform.position = Vector2.MoveTowards(transform.position,Player.transform.position , _enemySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            if (other.GetComponent<Health>() != null)
            {
                other.GetComponent<Health>().Damage(_enemyDamage);
                this.GetComponent<Health>().Damage(100);
            }
        }
    }
}
