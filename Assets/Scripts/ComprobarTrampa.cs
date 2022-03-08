using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprobarTrampa : MonoBehaviour
{
    public static bool tocaTrampa;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Trampa"))
        {
            tocaTrampa = true;
        }     
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Trampa"))
        {
            tocaTrampa = false;

        }
    }
}
