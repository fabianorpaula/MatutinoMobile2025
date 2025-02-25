using UnityEngine;

public class MoverFundo : MonoBehaviour
{
    public float meuTempo;


    void Update()
    {
        meuTempo += Time.deltaTime;
        
        if(meuTempo > 0.01f)
        {
            transform.position = transform.position + 
                new Vector3(0, -0.01f,0);
            meuTempo = 0;
        }

        if(transform.position.x < -12)
        {
            transform.position = new Vector3(0, 15, 0);
        }
    }
}
