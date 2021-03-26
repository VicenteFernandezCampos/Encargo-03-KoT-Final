using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cangrejo_Movement : MonoBehaviour
{
    public Transform transform;
    public bool izquierda;
    public bool derecha;
    //izquierda es True y derecha será False
    public Collider collider;
    public int velocidad;

    private void OnTrigger (Collider other)
    {
        if (other.gameObject.CompareTag "Suelo")
    }
}
