using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegarForma : MonoBehaviour
{
    [SerializeField]
    private Transform destinoObj;

    private bool atualizaPosicao = false;

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameObject pai = this.transform.parent.gameObject;

                //print("O meu pai é: " + pai.gameObject.name);

                pai.GetComponentInParent<Rigidbody>().useGravity = false;
                pai.transform.position = destinoObj.position;
                atualizaPosicao = true;
            }
            else
            {
                this.GetComponentInParent<Rigidbody>().useGravity = true;
                atualizaPosicao = false;
            }
        }
    }

    void Update()
    {
        if (atualizaPosicao)
        {
            GameObject pai = this.transform.parent.gameObject;

            pai.GetComponentInParent<Rigidbody>().useGravity = false;
            pai.transform.position = destinoObj.position;
        }
    }
}
