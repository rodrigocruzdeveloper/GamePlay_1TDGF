using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text textAir;
    [SerializeField] private Text textScore;

    public static int air;
    public static int score;
    public static bool inWater;

    void Start()
    {
        air = 10;
        score = 0;
        StartCoroutine(Air());
    }

    private void Update()
    {
        textScore.text = "Score: " + score.ToString();
    }

    IEnumerator Air()
    {
        if(inWater == true)
        {
            air--;
        }
        textAir.text = "Air: " + air.ToString() + "%";
        yield return new WaitForSeconds(1.0f);       
        StartCoroutine(Air());
    }

}
