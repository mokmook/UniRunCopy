using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    [SerializeField, Range(0, 10)] int JumpPower;
    [SerializeField] ParticleSystem DieEffect;
    [SerializeField] SpriteRenderer sprite;

    [Header("오디오 클립")]
    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip dieSound;
    [SerializeField] AudioClip getHitSound;


    Rigidbody2D rb;
    Animator anim;
    public int cur_hp { get; private set; } 


    public static bool isDead { get; private set; }

    
    int JumpCounter = 0;
    bool isGround = true;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        isDead = false;
        cur_hp = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && JumpCounter < 2)
        {
            rb.velocity = Vector2.up * JumpPower;
            JumpCounter++;
            AudioManager.instance.PlayAudioClip(jumpSound, transform);
        }   
        if (isGround)
        {
            anim.SetBool("Run", true);
        }
        else 
            anim.SetTrigger("Jump");

        if (cur_hp==0)
        {
            Die();
        }
       


    }
    void Die()
    {
        isDead = true;
        rb.gravityScale = 0;
        AudioManager.instance.PlayAudioClip(dieSound, transform);
        ParticleSystem.Instantiate(DieEffect,transform.position,Quaternion.identity);
        gameObject.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
            JumpCounter = 0;
            
        }
        if (collision.gameObject.tag == "Enemy")
        {
            cur_hp--;
            AudioManager.instance.PlayAudioClip(getHitSound, transform);
            StartCoroutine("GetHit");
            
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
            Die();
        }      
    }
  IEnumerator GetHit()
    {
        sprite.material.color = Color.red;
        yield return new WaitForSeconds(.5f);
        sprite.material.color = Color.white;
        yield break;
    }

}
