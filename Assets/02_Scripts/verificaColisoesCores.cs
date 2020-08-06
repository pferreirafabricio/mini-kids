using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class verificaColisoesCores : MonoBehaviour
{
    [SerializeField]
    private Transform[] posicoes;

    [SerializeField]
    private Text errado;

    [SerializeField]
    private controladorGeral cg;

    private string[] corDesejada = new string[4];

    private string corSorteada;

    void Start()
    {
        corDesejada[0] = "Vermelho";
        corDesejada[1] = "Azul";
        // corDesejada[2] = "Amarelo";
        // corDesejada[3] = "Verde";

        corSorteada = corDesejada[Random.Range(0, 1)];
        //corSorteada = "Vermelho";

        print(corSorteada);
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag(corSorteada))
        {
            col.gameObject.transform.position = posicoes[0].position;

            col.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
            col.gameObject.GetComponentInChildren<pegarForma>().enabled = false;

            cg.numCoresColocadas++;

            Destroy(col.gameObject, 1);
        }
    }

    IEnumerator exibirTexto()
    {
        errado.enabled = true;
        yield return new WaitForSeconds(2);
        errado.enabled = false;
    }
}
  
