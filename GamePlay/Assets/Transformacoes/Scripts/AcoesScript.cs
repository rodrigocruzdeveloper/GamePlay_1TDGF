using UnityEngine;
using UnityEngine.Jobs;

public class AcoesScript : MonoBehaviour
{
    [SerializeField] float velocidade;

    [SerializeField] Vector3 velocidadeXYZ;


    void Update()
    {
        // transform.Translate(velocidade * Time.deltaTime, 0.0f, 0.0f);
        // transform.Translate(velocidadeXY.x * Time.deltaTime, velocidadeXY.y * Time.deltaTime, 0.0f);
        //
        /* MOVIMENTO
        if(transform.position.x > 8.0f || transform.position.x < -8.0f)
        {
            velocidadeXYZ *= -1;
        }

        transform.Translate(velocidadeXYZ * Time.deltaTime);
        */

        /*
        if (transform.eulerAngles.z > 90.0f)
        {
            velocidade = 0.0f;
        }

        transform.Rotate(0.0f, 0.0f, velocidade * Time.deltaTime);
        */
        
    }
}
