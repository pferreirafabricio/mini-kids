using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlarSom : MonoBehaviour
{
    private bool somLigado = true;
    [SerializeField]
    private AudioSource somBackground;
    [SerializeField]
    private Image corBotao;

    public void mutarSom()
    {
        if (somLigado == true)
        {
            somBackground.enabled = false;
            corBotao.color = Color.red;
            somLigado = false;
        }
        else
        {
            somBackground.enabled = true;
            corBotao.color = Color.yellow;
            somLigado = true;
        }
    }
}
