using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cangrejo : MonoBehaviour
{
    public Transform transform;
    public bool izquierda;
    public bool derecha;
    public bool arriba;
    public bool abajo;
    public Collider collider;
    public int velocidad;

    private void OnTrigger(Collider other)
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
            MoverIzq();
        }

        if (arriba = true)
        {
            MoverDer();
        }

        if (izquierda = true)
        {
            MoverArriba();
        }

        if (derecha = true)
        {
            MoverAbajo();
        }
    }

    void MoverIzq()
    {
        Transform.Translate(Vector3.left * Time.deltaTime * velocidad);
    }

    void MoverDer()
    {
        Transform.Translate(Vector3.right * Time.deltaTime * velocidad);
    }

    void MoverArriba()
    {
        Transform.Translate(Vector3.up * Time.deltaTime * velocidad);
    }

    void MoverAbajo()
    {
        Transform.Translate(Vector3.down * Time.deltaTime * velocidad);
    }
}
