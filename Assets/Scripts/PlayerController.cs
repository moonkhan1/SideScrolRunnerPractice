using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float Horizontal;
    [Range(0, 15)]
    [SerializeField] float _speed;
    Rigidbody2D rb2d;
    [SerializeField] float JumpForce = 10f;
    [SerializeField] ForceMode2D forcemode;
    [SerializeField] bool OnGround = true;
    [SerializeField] Animator _animator;
    public bool DidFlip = true;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");

        transform.position += new Vector3(Horizontal * _speed, 0, 0) * Time.deltaTime;

        _animator.SetFloat("Speed", Mathf.Abs(Horizontal));


        if (Input.GetKeyDown(KeyCode.Space) && OnGround)
        {
            rb2d.AddForce(Vector2.up * JumpForce, forcemode);
            OnGround = false;
            _animator.SetFloat("Speed", 2);
            _animator.SetBool("IsJumping", true);
        }

         if(Horizontal > 0 && !DidFlip)
        {
            Turn();
        }
        if(Horizontal < 0 && DidFlip)
        {
            Turn();      
        }

        

    }


    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            _animator.SetBool("IsJumping", false);
            OnGround = true;
        }

    }

    void Turn()
    {
        transform.Rotate(0f, 180f, 0f);
        DidFlip = !DidFlip;
    }

    


}
