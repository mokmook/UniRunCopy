using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : PlatformClone
{
    //[SerializeField, Range(0,10)] float speed;


    [SerializeField] float minSpawnTime;
    [SerializeField] float MaxSpawnTime;

    [SerializeField] GameObject[] platform;
     public GameObject[] platforms { get; private set; }

    float LastActive;
    [SerializeField]int scoreTime;
    int score;

    [SerializeField] float xPos;
    [SerializeField] float MinYPos;
    [SerializeField] float MaxYPos;

    int count;
    int Count
    {
        get { return count; }
        set
        {
            if (value > 2)
                count = 0;
            else
                count = value;
        }
    }
    private void OnEnable()
    {
        LastActive = Time.time;
        score = 0;
        scoreTime = 1;      
    }

    private void Start()
    {    
        platforms=new GameObject[3];
        for (int i = 0; i < 3; i++)
        {
            platforms[i] = Instantiate(platform[i], new Vector2(0, -25), Quaternion.identity);
        }
        StartCoroutine(Platforms());
    }
    protected override void Update()
    {
        base.Update();
        print("½ºÄÚ¾î: "+score);
        if (Time.time>LastActive+scoreTime&&!Player.isDead)
        {
            score++;
            LastActive = Time.time;
        }
    }
    IEnumerator Platforms()
    {   
        while (!Player.isDead)
        {
            platforms[Count].transform.position = new Vector2(xPos, Random.Range(MinYPos, MaxYPos));
            Count += 1;
            yield return new WaitForSeconds(Random.Range(minSpawnTime, MaxSpawnTime));
        }
    }
    
}







