using UnityEngine;

public class ExercicioTransformacaoScript : MonoBehaviour
{
    [SerializeField] private float velocidade;

    void Start()
    {
        transform.position = new Vector2(0.0f, -3.0f);
    }

    
    void Update()
    {
        // MOVER
        Vector3 mover = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        mover = mover * velocidade * Time.deltaTime;
        transform.Translate(mover);


        // ALTERA A ESCALA DO SPRITE
        if (Input.GetButton("Fire1"))
        {
            transform.localScale = new Vector2(2.0f, 2.0f);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            transform.localScale = new Vector2(1.0f, 1.0f);
        }

        // LIMITE DA CAMERA
        if((transform.position.x < -10.0f || transform.position.x > 10) || 
            (transform.position.y < -5.0f || transform.position.y > 5.0f))
        {
            transform.position = Vector2.zero;
        }
    }
}
