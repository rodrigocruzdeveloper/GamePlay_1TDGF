using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;

    void Start()
    {
        transform.position = Vector2.zero;
    }
        
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x, y, 0.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Big")
        {
            if(transform.localScale.x < 6.0f)
            {
                transform.localScale = transform.localScale * 2;
            }            
        }
        else if (collision.collider.tag == "Small")
        {
            if (transform.localScale.x > 0.5f)
            {
                transform.localScale = transform.localScale / 2;
            }
        }
    }
}
