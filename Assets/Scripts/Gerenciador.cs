using UnityEngine;

public class Gerenciador : MonoBehaviour
{
    public GameObject Objeto;
    private float contador;
 
    void Update()
    {
        contador += Time.deltaTime;
        if(contador > 1)
        {
            GameObject MeuObjeto = Instantiate(Objeto, 
                transform.position, 
                Quaternion.identity);
            Destroy(MeuObjeto, 3f);
            contador = 0;
        }
        
             
    }
}
