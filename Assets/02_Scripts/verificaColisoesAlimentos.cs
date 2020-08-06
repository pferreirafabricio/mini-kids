using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class verificaColisoesAlimentos : MonoBehaviour
{
    [SerializeField]
    private Text sucesso;

    [SerializeField]
    private controladorGeral cg;

    IEnumerator sumirTexto()
    {
        sucesso.enabled = true;
        yield return new WaitForSeconds(3.5f);
        sucesso.enabled = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (this.gameObject.name == "Galinha")
        {
            if (col.gameObject.name == "Milho")
            {  
                Destroy(col.gameObject, 0.5f);

                sucesso.text = "Você alimentou com sucesso a(o): Galinha";
                cg.numAnimaisAlimentados++;
                StartCoroutine(sumirTexto());
            }
        }

        if (this.gameObject.name == "Gato")
        {
            if (col.gameObject.name == "Leite")
            {  
                Destroy(col.gameObject, 0.5f);

                sucesso.text = "Você alimentou com sucesso a(o): Gato";
                cg.numAnimaisAlimentados++;
                StartCoroutine(sumirTexto());
            }
        }

        if (this.gameObject.name == "Porco")
        {
            if (col.gameObject.name == "Lavagem")
            {  
                Destroy(col.gameObject, 0.5f);

                sucesso.text = "Você alimentou com sucesso a(o): Porco";
                cg.numAnimaisAlimentados++;
                StartCoroutine(sumirTexto());
            }
        }

        if (this.gameObject.name == "Vaca")
        {
            if (col.gameObject.name == "Capim")
            {  
                Destroy(col.gameObject, 0.5f);

                sucesso.text = "Você alimentou com sucesso a(o): Vaca";
                cg.numAnimaisAlimentados++;
                StartCoroutine(sumirTexto());
            }
        }
    }
    
}
