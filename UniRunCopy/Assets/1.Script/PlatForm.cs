using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField, Range(0, 3)] float speed;

    [SerializeField] float spawnTimeMin;
    [SerializeField] float spawnTimeMax;
    float spawnTime;

    [SerializeField] GameObject[] platform;
    int cur_index = 0;

    float xPos = 0;
    [SerializeField] float yMin = -2;
    [SerializeField] float yMax = 1;

    Vector2 defalutSpwan = new Vector2(0, -25);
    float lastSpawnTime;

    GameObject PlatformPrefab;

    
	
    private void Start()
    {
   
    }
    void Update()
    {
        
        if(GameManager.isDead)
            transform.position -= Camera.main.transform.right * speed * Time.deltaTime;
        
    }
}

   
