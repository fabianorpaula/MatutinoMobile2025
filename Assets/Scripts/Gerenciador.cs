using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering;

public class Gerenciador : MonoBehaviour
{
    public List<GameObject> Objetos;
    private float contador;
 
    void Update()
    {
        contador += Time.deltaTime;
        if(contador > 1)
        {
            //Nova Posicção Randomica
            float px = Random.Range(-2, 2);
            Vector3 novapos = new Vector3(px, 6, 0);
            
            //Novo Objeto
            int indice = Random.Range(0, Objetos.Count);
            GameObject MeuObjeto = Instantiate(Objetos[indice], 
                novapos, 
                Quaternion.identity);
            Destroy(MeuObjeto, 3f);
            contador = 0;
        }
        
             
    }
}
