using MoreMountains.CorgiEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llave1 : MonoBehaviour
{
    [SerializeField] protected GameObject Objetollave;
    [SerializeField] protected  GameObject ColliderPuerta;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ColliderPuerta.gameObject.SetActive(true);
            Destroy(Objetollave);
        }
    }
}
