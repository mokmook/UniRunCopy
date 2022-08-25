using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //[SerializeField] GameObject enemyPrefab;
    Vector2 enemyPos;
    private void Awake()
    {
        //enemyPos = this.transform.position;
    }
  
    protected virtual void OnEnable()
    {
        //this.transform.position = new Vector2(enemyPos.x, transform.position.y);
        //bool isActive;
        //isActive=Random.Range(0,2)==0?true:false;
        //gameObject.SetActive(isActive);
        //print(isActive);
    }

}
