using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    [SerializeField] Animator _animator;
    GameObject attackArea = default;
    bool IsAttacking = false;
    float Reload = 0.4f;
    float count = 0f;

    void Start()
    {
        attackArea = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();

        if (IsAttacking)
        {
            count += Time.deltaTime;

            if(count >= Reload)
            {
                count = 0;
                IsAttacking = false;
                attackArea.SetActive(IsAttacking);
            }
        }
        
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _animator.SetBool("IsMeleeAttack", true);
            IsAttacking = true;
            attackArea.SetActive(IsAttacking);
        }
        if (!Input.GetKeyDown(KeyCode.Q)){
            _animator.SetBool("IsMeleeAttack", false);
        }
    }
}
