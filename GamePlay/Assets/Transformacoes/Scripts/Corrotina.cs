using System.Collections;
using UnityEngine;

public class Corrotina : MonoBehaviour
{
    
    void Start()
    {
        // StartCoroutine(Contador());
        StartCoroutine(Sequencia());
    }

    IEnumerator Sequencia()
    {
        yield return new WaitForSeconds(5.0f);
        print("Esperei 5 seg.");

        yield return new WaitForSeconds(2.0f);
        print("Esperei 2 seg.");

        yield return new WaitForSeconds(0.5f);
        print("Fim.");
    }





    IEnumerator Contador()
    {
        int a = 0;

        while(a < 10)
        {
            print(a);
            a++;
            yield return new WaitForSeconds(5.0f);      // PAUSA DE 1F = 1 SEGUNDO
        }        
    }



}
