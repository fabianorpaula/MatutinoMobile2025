using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorJogo : MonoBehaviour
{

    public bool estadoJogo;
    //public bool gameState = true;
    //O que?
     void Start()
    {
        Time.timeScale = 1;
    }
    public void IniciarJogo()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("Fase1");

    }

    public void PausarJogo()
    {
        Time.timeScale = 0;
        estadoJogo=false;

    }


    public bool EstadoAtual()
    {
        return estadoJogo;
    }


}
