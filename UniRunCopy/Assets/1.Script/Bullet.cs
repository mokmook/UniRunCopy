using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int speed;
    [SerializeField] Transform playerTr;
    [SerializeField] GameObject bullet;   
    [SerializeField]float attackDelay;

    Rigidbody2D objRb;
    Animator objAnim;
    float activeA=0;
    GameObject Obj;
    void Start()
    {
        objAnim = Obj.GetComponent<Animator>();
        objRb=Obj.GetComponent<Rigidbody2D>();
        Obj=Instantiate(bullet, playerTr.position, Quaternion.identity);
        Obj.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > attackDelay + activeA)
        {
           Obj.gameObject.SetActive(true);
            Attack();

        }
        
    }
    void Hide()
    {
        Obj.gameObject.SetActive(false);
    }
    void Attack()
    {
        transform.position = playerTr.position;
        activeA = Time.time;
        objRb.velocity = -Vector2.left * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
           Obj.gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
        }
    }
}
