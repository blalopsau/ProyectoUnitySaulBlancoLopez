using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ComprobarLava : MonoBehaviour
{
    public static bool tocaLava;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            tocaLava = true;
        }     
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Lava"))
        {
            tocaLava = false;

        }
    }
}
