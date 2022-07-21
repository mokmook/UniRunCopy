using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    RaycastHit2D hit;
    [SerializeField] float Distance;
    int a;
    int b;

    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        int a=Random.Range(0,2);
        int b=Random.Range(0,2);
    }

    void Update()
    {
        if (Physics2D.Raycast(transform.position,Vector2.left,Distance,0<<3))
        {
            switch (a)
            {
                case 0:rb2d.AddForce(Vector2.up*3, ForceMode2D.Impulse);
                    break;
            }
            a = Random.Range(0, 2);
        }
        Debug.DrawRay(transform.position, Vector2.left, color: Color.red);
        print(a);
        /*if (b==0)
        {
            gameObject.SetActive(false);
            b = Random.Range(0, 2);
        }*/
    }
    
}
