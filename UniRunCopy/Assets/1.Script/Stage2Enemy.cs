using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Enemy : Enemy
{
    Rigidbody2D rb;
    protected override void OnEnable()
    {
        base.OnEnable();
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (gameObject.activeSelf)
        {
            rb.velocity =Vector2.left;
        }
    }
}
