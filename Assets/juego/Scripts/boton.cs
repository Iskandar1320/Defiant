using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boton : MonoBehaviour
{
    public GameObject ObjetoBoton;
    public GameObject ColliderPlataforma;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ColliderPlataforma.gameObject.SetActive(true);
            Destroy(ObjetoBoton);
        }
    }
}
