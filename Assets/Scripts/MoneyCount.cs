using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyCount : MonoBehaviour
{
    //Definerer tekstfelt der skal vise money count
    public Text score;

    //Definerer int der skal være værdien for din money count
    public int scoreAmount;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Konverterer scoreAmount til en string, så det kan vises i UI. Den er sat i Update, så den hele tiden tjekker om værdien har ændrete sig, så den kan konvertere det til string igen
        score.text = scoreAmount.ToString();
    }

    public void addScore()
    {
        scoreAmount += 10;
    }

    public void removeScore()
    {
        scoreAmount -= 10;
    }

}
