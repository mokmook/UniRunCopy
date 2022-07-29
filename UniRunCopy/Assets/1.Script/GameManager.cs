using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField] Image[] heart;
    [SerializeField] Sprite[] heartDie;
    int hp;
    void Start()
    {
        heart=new Image[heart.Length];
        heartDie=new Sprite[heart.Length];
        hp = FindObjectOfType<Player>().cur_hp;
    }

    void Update()
    {
        switch (hp)
        {
            case 1:
                heart[1].sprite = heartDie[1];
                heart[2].sprite = heartDie[2];
                break;
            case 2:
                heart[2].sprite = heartDie[2];
                break;
        }
        if (Player.isDead)
        {
            for (int i = 0; i < 3; i++)
            {
                heart[i].sprite = heartDie[i];
            }
        }

    }
}
