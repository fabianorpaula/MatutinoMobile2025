using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorJogo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void IniciarJogo()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(1);
        //SceneManager.LoadScene("Fase1");

    }


}
