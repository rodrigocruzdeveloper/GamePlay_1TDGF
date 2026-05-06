using UnityEngine;

public class InputScript : MonoBehaviour
{

    [SerializeField] bool jumpButton;
    [SerializeField] float velocidade = 10;
    
    void Update()
    {
        // EXEMPLO DE USO DE EIXOS PARA MOVIMENTACAO

        // INPUT
        float moverX = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        float moverY = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;

        // MOVIMENTO
        transform.Translate(moverX, moverY, 0.0f);



        // EXEMPLO DE USO DE BOTAO
        if (Input.GetButtonDown("Jump"))
        {
            // TRUE QUANDO DER O PRIMEIRO TOQUE NO BOTAO E VOLTA A FICAR FALSE

            byte r = (byte)Random.Range(0, 255);
            byte g = (byte)Random.Range(0, 255);
            byte b = (byte)Random.Range(0, 255);
            Color32 cor = new Color32(r, g, b, 255);
            GetComponent<SpriteRenderer>().color = cor;            
        }
        else if (Input.GetButton("Jump"))
        {
            // TRUE ENQUANTO O BOTAO ESTIVER PRESSIONANDO
            transform.Rotate(0.0f, 0.0f, 100.0f * Time.deltaTime);
        }
        else if (Input.GetButtonUp("Jump"))
        {
            // TRUE QUANDO O BOTAO FOR LIBERADO
            GetComponent<SpriteRenderer>().color = Color.white;
        }
            
            

    }
}
