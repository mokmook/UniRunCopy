using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformClone : MonoBehaviour
{
    [SerializeField]float speed=8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   protected virtual void Update()
    {
        if (!Player.isDead)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
}
