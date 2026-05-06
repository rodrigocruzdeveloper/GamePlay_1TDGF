using UnityEngine;

public class TransformadoreScript : MonoBehaviour
{
    [SerializeField] Vector2 posicao;


    void Start()
    {
        // ATRIBUICAO UM TRANSFORM
        transform.position = new Vector2(0.0f, 0.0f);
        transform.eulerAngles = new Vector3(0.0f, 0.0f, 45.0f);
        transform.localScale = new Vector2(2.0f, 4.0f);

        // OBTER VALOR DE UM TRANSFORM
        print("POSIÇÃO: " + transform.position);
        print("ROTAÇÃO:" + transform.eulerAngles);
        print("ESCALA: " + transform.localScale);

    }
   
}
