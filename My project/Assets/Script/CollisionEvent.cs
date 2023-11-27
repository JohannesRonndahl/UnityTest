using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Use with a Collider component
// When another collider enters the collider with the script an event will trigger
public class CollisionEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent onCollision;

    private void OnTriggerEnter2D(Collider2D other)
    {
        onCollision.Invoke();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        onCollision.Invoke();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        onCollision.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        onCollision.Invoke();
    }
}
