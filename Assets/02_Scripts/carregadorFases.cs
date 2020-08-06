using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class carregadorFases : MonoBehaviour
{
    public void CarregarFase(int faseDesejada)
    {
        SceneManager.LoadScene(faseDesejada, LoadSceneMode.Single);
    }

    public void recarregarFase()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
}
