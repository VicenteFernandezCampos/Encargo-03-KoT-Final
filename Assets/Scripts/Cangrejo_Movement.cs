using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cangrejo_Movement : MonoBehaviour
{
    public Transform transform;
    public bool izquierda;
    public bool derecha;
    public bool arriba;
    public bool abajo;
    public Collider collider;
    public int velocidad;

    private void OnTrigger (Collider other)
    {
        if (other.gameObject.CompareTag "Suelo")
        {
            abajo = true;
        }

        if (other.gameObject.CompareTag "ParedIzq")
        {
            izquierda = true;
        }

        if (other.gameObject.CompareTag "Techo")
        {
            arriba = true;
        }

        if (other.gameObject.CompareTag "ParedDer")
        {
            derecha = true;
        }
    }

    void Update()
    {
        if (abajo = true)
        {

        }
    }
}
