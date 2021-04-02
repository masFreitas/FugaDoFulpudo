using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinhocarScript : MonoBehaviour
{
    public float velocity;
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        this.body = GetComponent<Rigidbody2D>();
        this.body.velocity = new Vector2(this.velocity, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
