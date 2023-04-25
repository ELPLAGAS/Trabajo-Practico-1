using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humano : MonoBehaviour
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public float velocidadMovimiento = 10f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 movimiento = new Vector3(horizontal, 0f, vertical);
        transform.position += movimiento.normalized * velocidadMovimiento * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Bot>() != null)
        {
            other.gameObject.GetComponent<Bot>().Saludar(this);
        }
    }
}
