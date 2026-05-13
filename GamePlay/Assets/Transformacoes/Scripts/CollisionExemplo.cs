using UnityEngine;

public class CollisionExemplo : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "Ground")
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }



        // print(collision.collider.name);
        // transform.localScale = new Vector2(2.0f, 2.0f);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.name == "Base")
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "Ground")
        {
            transform.localScale = new Vector2(1.0f, 2.0f);
        }


        // transform.localScale = new Vector2(1.0f, 1.0f);
        // GetComponent<SpriteRenderer>().color = Color.white;
    }

}
