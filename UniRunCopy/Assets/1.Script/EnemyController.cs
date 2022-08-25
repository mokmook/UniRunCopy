using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemy;
    public Vector2 enemyPosition;

    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        //bool isActive;
        //isActive = Random.Range(0, 2) == 0 ? true : false;

        if(Random.Range(0,3) == 0)
        {
            enemy.gameObject.SetActive(true);
            enemy.transform.localPosition = enemyPosition;
            //enemy.transform.position = new Vector2(enemyPosition.x, this.transform.position.y);
            //enemy.transform.localPosition = new Vector2(enemyPosition.x, this.transform.position.y);
        }
        else
        {
            enemy.gameObject.SetActive(false);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
