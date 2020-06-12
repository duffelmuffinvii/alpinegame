﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool isGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, GetComponent<Collider2D>().bounds.extents.y + 0.1f);

        if (hit.collider != null)
        {
            return true;
        }
        else return false;
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (isGrounded()) transform.Translate(new Vector2(moveHorizontal * 0.04f, 0));
        else transform.Translate(new Vector2(moveHorizontal * 0.03f, 0));

        if (Input.GetKeyDown("space"))
        {
            if (isGrounded()) {
                rb.AddForce(new Vector2(0, 10.0f), ForceMode2D.Impulse);
            }
        }


    }


}
