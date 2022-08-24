using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    protected virtual void OnEnable()
    {
        bool isActive;
        isActive=Random.Range(0,2)==0?true:false;
        gameObject.SetActive(isActive);
        print(isActive);
    }

}
