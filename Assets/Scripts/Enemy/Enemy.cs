using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D myBody;
    // Start is called before the first frame update

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
