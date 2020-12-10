using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1f;
    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range (minSpeed,maxSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 forward = new Vector2 (transform.right.x , transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
        Destroy(gameObject,5f);
    }
}
