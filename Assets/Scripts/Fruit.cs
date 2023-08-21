using System;
using System.Security.AccessControl;
using System.Diagnostics;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Fruit : MonoBehaviour
{
    protected virtual void Eat()
    {
        FindObjectOfType<GameManager>().FruitEaten(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.gameObject.layer == LayerMask.NameToLayer("Pacman")) {
            Eat();
        }
    }

}