using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    private int _maxHealth = 100;


    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    public void SetHealth(int MaxHealth, int health)
    {
        this._maxHealth = MaxHealth;
        this._health = health;
    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            Debug.Log("No");
        }
        this._health -= amount;
        
        if(_health <= 0)
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
