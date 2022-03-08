using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{
    public void PulsarBoton()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Debug.Log("pulsado boton");
    }
}
