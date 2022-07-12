using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Range(0, 5)] int JumpPower;
    [SerializeField] ParticleSystem DieEffect;
    Rigidbody2D rb;
    Animator anim;

    bool isDead = false;
    int JumpCounter = 0;
    bool isGround = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && JumpCounter < 2)
        {
            rb.velocity = Vector2.up * JumpPower;
            JumpCounter++;
            
        }

        if (isGround)
        {
            anim.SetBool("Run", true);
        }
        else 
            anim.SetTrigger("Jump");






    }
    void Die()
    {
        rb.gravityScale = 0;
        ParticleSystem.Instantiate(DieEffect,transform.position,Quaternion.identity);
        Destroy(GameObject.FindGameObjectWithTag("Player"));

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
            JumpCounter = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
        if (collision.tag == "Dead"&&!isDead)
        {
            isDead=true;
            Die();
        }
    }
}
