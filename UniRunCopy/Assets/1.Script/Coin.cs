using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject[] coin;
    GameManager gm;
    private void Awake()
    {
        gm=FindObjectOfType<GameManager>();
    }

    private void OnEnable()
    {
        gameObject.SetActive(true); 
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
