using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TelaVida : MonoBehaviour
{
    private TMP_Text meuTexto;
    private Personagem DadosPersonagem;
    public Image barraVIda;
    void Start()
    {
        meuTexto = GetComponent<TMP_Text>();
        DadosPersonagem = GameObject.
            FindGameObjectWithTag("Player").
            GetComponent<Personagem>();
    }
    void Update()
    {
        meuTexto.text = "VIDA :" + DadosPersonagem.Vida.ToString();
        int vidaAtual = DadosPersonagem.Vida * 108;

        barraVIda.rectTransform.sizeDelta = 
            new Vector2(vidaAtual, 100);
    }
}
