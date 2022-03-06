using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarSuelo : MonoBehaviour
{
    public static bool tocaSuelo;
    public static bool tocaLava;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Suelo"))
        {
            tocaSuelo = true;
        }

        if (collision.CompareTag("Lava"))
        {
            tocaLava = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Suelo"))
        {
            tocaSuelo = false;

        }
        if (collision.CompareTag("Lava"))
        {
            tocaLava = false;

        }
    }
}
