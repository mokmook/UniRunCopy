using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameManager gm;
    private void Awake()
    {
        gm=FindObjectOfType<GameManager>();
    }

    private void OnEnable()
    {
        if (Random.Range(0,2)==0)        
            gameObject.SetActive(true);        
        else
            gameObject.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            gm.AddScore(1);
            gameObject.SetActive(false);
        }
    }
    
}
