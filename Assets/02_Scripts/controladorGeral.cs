using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controladorGeral : MonoBehaviour
{
    public int numFormasEncaixadas = 0;

    public int numCoresColocadas = 0;

    public int numAnimaisAlimentados = 0;

    [SerializeField]
    private GameObject pnSucesso;
    [SerializeField]
    private GameObject pnPause;

    [SerializeField]
    private Text txtAjuda;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        //Nível 1
        if (numFormasEncaixadas == 4)
        {
            painelSucesso();
        }

        //Nível 2
        if (numCoresColocadas == 3)
        {
            painelSucesso();
        }

        //Nível 3
        if (numAnimaisAlimentados == 4)
        {
            painelSucesso();
        }

        //Pausar o jogo
        if (Input.GetKeyDown(KeyCode.P))
        {
            pnPause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void SairJogo()
    {
        print("To saindo!");
        Application.Quit();
    }

    public void voltarTelaInicial()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
   
    private void painelSucesso()
    {
        pnSucesso.SetActive(true);
        txtAjuda.enabled = false;
        Time.timeScale = 0;
    }

    public void continuar()
    {
        pnPause.SetActive(false);
        Time.timeScale = 1;
    }
   
}
