using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cangrejo : MonoBehaviour
{
    public Transform theTransform;
    public bool izquierda;
    public bool derecha;
    public bool arriba;
    public bool abajo;
    public Collider theCollider;
    public int velocidad;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Suelo"))
        {
            abajo = true;
        }

        if (other.gameObject.CompareTag("ParedIzq"))
        {
            izquierda = true;

        }

        if (other.gameObject.CompareTag("Techo"))
        {
            arriba = true;
        }

        if (other.gameObject.CompareTag("ParedDer"))
        {
            derecha = true;

        }
    }

    void Update()
    {
        if (abajo == true)
        {
            MoverIzq();
            derecha = false;
        }

        if (arriba == true)
        {
            MoverDer();
            izquierda = false;
        }

        if (izquierda == true)
        {
            MoverArriba();
            abajo = false;
        }

        if (derecha == true)
        {
            MoverAbajo();
            arriba = false;
        }
    }

    void MoverIzq()
    {
        theTransform.Translate(Vector3.left * Time.deltaTime * velocidad);
    }

    void MoverDer()
    {
        theTransform.Translate(Vector3.right * Time.deltaTime * velocidad);
    }

    void MoverArriba()
    {
        theTransform.Translate(Vector3.up * Time.deltaTime * velocidad);
    }

    void MoverAbajo()
    {
        theTransform.Translate(Vector3.down * Time.deltaTime * velocidad);
    }
}
