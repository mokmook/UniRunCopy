using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
    [SerializeField, Range(0, 3)] float speed;
    void Update()   
    {
       //transform.position -= Camera.main.transform.right *speed*Time.deltaTime;
    }
}
