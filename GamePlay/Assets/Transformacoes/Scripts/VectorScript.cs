using UnityEngine;

public class VectorScript : MonoBehaviour
{
    // ARMAZENANDO UM VALOR CARTESIANO 2D
    [SerializeField] Vector2 posicao;
    [SerializeField] Vector2 rotacao;
    [SerializeField] Vector2 escala;

    private void Start()
    {
        print("UP: " + Vector2.up);
        print("DOWN: " + Vector2.down);
        print("LEFT: " + Vector2.left);
        print("RIGHT: " + Vector2.right);

        posicao = new Vector2(10.0f, 5.0f);

    }



}
