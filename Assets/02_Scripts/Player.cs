using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float velXY;
    [SerializeField]
    private float velZ;
    [SerializeField]
    private Animator animMago;

    private InputManager axis;

    private float velRotacao;

    public Camera cam;

    [SerializeField]
    private GameObject origemRaio;

    void Start()
    {
        velRotacao = 50;
        velXY = 1;
        velZ = 1;
        
        axis = cam.GetComponent<InputManager>();
    }

    void Update()
    {
        Movimentacao();

        //mudaVisaoCamX();

        if (Input.GetButton("Fire1"))
        {
            animMago.SetBool("LevantarCajado", true);

            RaycastHit hit;

            if (Physics.Raycast(origemRaio.transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                Debug.DrawRay(origemRaio.transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.gray); //
                Debug.Log("Bati em " + hit.transform.tag);  
                
            }
            else
            {
                Debug.DrawRay(origemRaio.transform.position, transform.TransformDirection(Vector3.forward), Color.blue);
                Debug.Log("Não bati em algo");
            }
        }
        else
        {
            animMago.SetBool("LevantarCajado", false);
        }
        
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
        {
            animMago.SetBool("Voar", true);
            transform.Translate(0, 0, velZ * Time.deltaTime);
        }
        else
        {
            animMago.SetBool("Voar", false);
        }

    }

    void Movimentacao()
    {
        //animMago.SetFloat("Movimento", Input.GetAxis("Vertical"));
        animMago.SetFloat("MovimentoFT", Input.GetAxis("Vertical"), 0.3f, Time.deltaTime);
        animMago.SetFloat("MovimentoDE", Input.GetAxis("Horizontal"), 0.3f, Time.deltaTime);

        //Movimento esquerda
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(velXY * Time.deltaTime, 0, 0);
        }

        //Movimento direita
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-velXY * Time.deltaTime, 0, 0);
        }

        //Movimento frente
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, velZ * Time.deltaTime);
        }

        //Movimento trás
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -velZ * Time.deltaTime);
        }

        //Rotaciona para o lado direito no eixo Y
        if (axis.MouseX > 0)
        {
            transform.Rotate(0, ((axis.MouseX * Time.deltaTime) * velRotacao), 0);
        }

        //Rotaciona para o lado esquerdo no eixo Y
        if (axis.MouseX < 0)
        {
            transform.Rotate(0, ((axis.MouseX * Time.deltaTime) * velRotacao), 0);
        }

    }

    void mudaVisaoCamX()
    {
        if (axis.MouseY > 0)
        {
            transform.Rotate(((axis.MouseY * Time.deltaTime) * velRotacao), 0, 0);
        }
        
        if (axis.MouseY < 0)
        {
            transform.Rotate(((axis.MouseY * Time.deltaTime) * velRotacao), 0, 0);   
        }

    }
}