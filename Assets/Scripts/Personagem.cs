using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int Vida = 10;
    public int Diabetes = 0;




    private void Update()
    {
        Mover();
    }

    void Mover()
    {
        Vector3 destino = Input.mousePosition;

        Vector3 posTela = Camera.main.ScreenToWorldPoint(destino);

        Vector3 posTelaCorrigida = new Vector3(posTela.x, 
            posTela.y + 1, 0);

        transform.position = Vector3.MoveTowards(transform.position, 
            posTelaCorrigida, 0.01f);
    }



    private void OnCollisionEnter2D(Collision2D colidiu)
    {
        if(colidiu.gameObject.tag == "Doce")
        {
            Diabetes++;
        }
        if(colidiu.gameObject.tag == "Veneno")
        {
            Vida--;
            if(Vida <= 0)
            {   Time.timeScale = 0;
                Destroy(this.gameObject);
            }
        }

        Destroy(colidiu.gameObject);


    }

}
