﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class Bird : MonoBehaviour
{

    private const float JUMP_AMOUNT = 50f;

    private Rigidbody2D birdRigidbody2D;

    private void Awake()
    {
        birdRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        birdRigidbody2D.velocity = Vector2.up * JUMP_AMOUNT;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CMDebug.TextPopupMouse("You Noob");
    }

}
