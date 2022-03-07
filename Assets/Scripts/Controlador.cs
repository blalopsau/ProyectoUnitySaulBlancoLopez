using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    public Animator animacion;
    public SpriteRenderer spRender;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Iniciar");
    }

    // Update is called once per frame
    void Update()
    {
        TipoAnimacion tipoAnimacion = TipoAnimacion.Parado;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 posicion = transform.position;

        // dirX toma valores entre -1 y 1

        if (Input.GetKey("a"))
        {
            tipoAnimacion = TipoAnimacion.Correr;
            rb.velocity = new Vector2(-7, rb.velocity.y);
            spRender.flipX = true;
        }
        else if (Input.GetKey("d"))
        {
            tipoAnimacion = TipoAnimacion.Correr;
            rb.velocity = new Vector2(7, rb.velocity.y);
            spRender.flipX = false;
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            tipoAnimacion = TipoAnimacion.Parado;
        }

        if (Input.GetKey(KeyCode.Space) && ComprobarSuelo.tocaSuelo)
        {
            rb.velocity = new Vector2(rb.velocity.x, 7);
        }

        if (Mathf.Abs(rb.velocity.y) > 0.1f)
        {
            tipoAnimacion = TipoAnimacion.Saltar;
        }
        
        if (ComprobarLava.tocaLava)
        {
            Vector2 position = transform.position;
            position.x = 32.361f;
            position.y = 19.115f;
            transform.position = position;
        }

        animacion.SetInteger("estado", (int)tipoAnimacion);
    }

    public enum TipoAnimacion
    {
        Parado,
        Correr,
        Saltar
    }

}
