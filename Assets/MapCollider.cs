﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCollider : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) {
 
       // if (collision.gameObject.CompareTag("MapColliders")) {
       //    Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
       // }
 
    }
}
