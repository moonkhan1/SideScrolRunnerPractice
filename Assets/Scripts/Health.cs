using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    private int _maxHealth = 100;


    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    public void SetHealth(int MaxHealth, int health)
    {
        this._maxHealth = MaxHealth;
        this.health = health;
    }

    public void Damage(int damage)
    {
        if(damage > 0)
        {
            this.health -= damage;
        }
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // public void Heal(int amount)
    // {
    //     if(amount > 0)
    //     {
    //         if (health + amount > _maxHealth)
    //         {
    //             this.health = _maxHealth;
    //         }
    //         else
    //         {
    //             this.health += amount;
    //         }
    //     }
    // }
}
