using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verificaColisoes : MonoBehaviour
{
    [SerializeField]
    private Transform[] encaixes;

    // [SerializeField]
    // private Transform encaixeCirculo;
    
    [SerializeField]
    private controladorGeral cg;

    
    //formaDesejada = new int[4];
    //0 - Ciruclo
    //1 - Quadrado
    //2 - Triangulo
    //3 - Retângulo

    void OnTriggerEnter(Collider col)
    {
        
        if (encaixes.Length == 4)
        {
            if (this.gameObject.name == "verificaCirculo") //Circulo
            {
                if (col.gameObject.tag == "formaCirculo")
                {
                    
                    col.gameObject.transform.position = encaixes[0].position;
                    cg.numFormasEncaixadas += 1;
                    
                    col.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
                    col.gameObject.GetComponentInChildren<pegarForma>().enabled = false;

                    col.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                
                    this.gameObject.GetComponent<verificaColisoes>().enabled = false;
                }

                
            }

            if (this.gameObject.name == "verificaQuadrado") //Quadrado
            {
                if (col.gameObject.tag == "formaQuadrado")
                {
                    col.gameObject.transform.position = encaixes[1].position;
                    cg.numFormasEncaixadas += 1;

                    col.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
                    col.gameObject.GetComponentInChildren<pegarForma>().enabled = false;

                    col.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                
                    this.gameObject.GetComponent<verificaColisoes>().enabled = false;
                }

                
            }

            if (this.gameObject.name == "verificaTriangulo") //Triangulo
            {
                if (col.gameObject.tag == "formaTriangulo")
                {
                    col.gameObject.transform.position = encaixes[2].position;
                    cg.numFormasEncaixadas += 1;

                    col.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
                    col.gameObject.GetComponentInChildren<pegarForma>().enabled = false;

                    col.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                
                    this.gameObject.GetComponent<verificaColisoes>().enabled = false;
                }
            }

            if (this.gameObject.name == "verificaRetangulo") //Triangulo
            {
                if (col.gameObject.tag == "formaRetangulo")
                {
                    col.gameObject.transform.position = encaixes[3].position;
                    cg.numFormasEncaixadas  += 1;

                    col.gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
                    col.gameObject.GetComponentInChildren<pegarForma>().enabled = false;

                    col.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                
                    this.gameObject.GetComponent<verificaColisoes>().enabled = false;
                }
            }
        }
    }
}
