using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    //[SerializeField, Range(0,10)] float speed;
    public static float speed { get; private set; }
    

    [SerializeField]float minSpawnTime;
    [SerializeField] float MaxSpawnTime;

    [SerializeField] GameObject platform0;
    [SerializeField] GameObject platform1;
    [SerializeField] GameObject platform2;

    [SerializeField] float xPos;
    [SerializeField] float MinYPos;
    [SerializeField] float MaxYPos;

    bool first = true;
    int a;
    int b;

    private void Start()
    {
        speed = 8;
            random();

            platform0 = Instantiate(platform0, new Vector2(0, -25), Quaternion.identity);
            platform1 = Instantiate(platform1, new Vector2(0, -25), Quaternion.identity);
            platform2 = Instantiate(platform2, new Vector2(0, -25), Quaternion.identity);
        
    }
    void Update()
    {

        if (!GameManager.isDead)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
            
        }   
    }
    void random()
    {
        if (GameManager.isDead)
            return;
            //int r = Random.Range(0, 3);

        if (!first)
        {
            do
            {
                a = Random.Range(0, 3);
            } while (a == b);
            b = a;
        }
        else
        {
            a = Random.Range(0, 3);
            b = a;
            first = false;
        }
        
        //이전에 생성된 r값과 다시 생선된 r값이 다를경우에만 switch생성 
            switch (b)
            {
                case 0:
                    Invoke("SpawnPlatform0", Random.Range(minSpawnTime, MaxSpawnTime)); break; // 0.5~1.5
                case 1:
                    Invoke("SpawnPlatform1", Random.Range(minSpawnTime, MaxSpawnTime)); break;
                case 2:
                    Invoke("SpawnPlatform2", Random.Range(minSpawnTime, MaxSpawnTime)); break;
            }

    }
    void SpawnPlatform0()
    {
        platform0.transform.position=new Vector2(xPos, Random.Range(MinYPos,MaxYPos));
        random();
    }
    void SpawnPlatform1()
    {
        platform1.transform.position = new Vector2(xPos, Random.Range(MinYPos, MaxYPos));
        random();

    }
    void SpawnPlatform2()   
    {
        platform2.transform.position = new Vector2(xPos, Random.Range(MinYPos, MaxYPos));
        random();

    }
}


