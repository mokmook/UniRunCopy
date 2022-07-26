using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : PlatformClone
{
    //[SerializeField, Range(0,10)] float speed;


    [SerializeField] float minSpawnTime;
    [SerializeField] float MaxSpawnTime;

    [SerializeField] GameObject[] platform;

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


    private void Start()
    {
        StartCoroutine(Platforms());
        platform=new GameObject[count];

        foreach (var item in platform)
        {
            platform[count] = Instantiate(platform[count], new Vector2(0, -25), Quaternion.identity);
        }


    }
    protected override void Update()
    {
        base.Update();
        print(count);
    }
    
    IEnumerator Platforms()
    {
    
        while (!Player.isDead)
        {
            platform[count].transform.position = new Vector2(xPos, Random.Range(MinYPos, MaxYPos));
            count++;
            yield return new WaitForSeconds(Random.Range(minSpawnTime, MaxSpawnTime));
        }
    }
}







