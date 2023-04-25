using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public Humano Humano;

    public void Saludar(Humano humano)
    {
        string Juan = humano.Nombre;
        humano.Nombre = "nombre modificado";
        string Jorge = humano.Nombre;
        Debug.Log("Hola " + Juan + ", ahora te llamas " + Jorge + ".");
    }

    void Update()
    {
        // Mover el Bot
        transform.position += new Vector3(0.1f, 0f, 0f) * Time.deltaTime * 10f;
    }
}
