using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int Vida = 10;
    public int Diabetes = 0;


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
            {
                Time.timeScale = 0;
                Destroy(this.gameObject);
            }
        }

        Destroy(colidiu.gameObject);


    }

}
