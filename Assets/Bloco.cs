using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour {

    public Rigidbody2D rigidBody;
    public BoxCollider2D collider;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        rigidBody.constraints = new RigidbodyConstraints2D();
        collider.isTrigger = true;
    }
}
