using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiVariables : MonoBehaviour
{
    //Definerer tekstfelt der skal vise counts
    public Text MoneyCount;
    public Text HungerCount;

    //Definerer int der skal v�re v�rdien
    public int moneyAmount;
    public int hungerAmount;

    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = 0;
        hungerAmount = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //Konverterer Amounts til en string, s� det kan vises i UI. Den er sat i Update, s� den hele tiden tjekker om v�rdien har �ndrete sig, s� den kan konvertere det til string igen
        MoneyCount.text = moneyAmount.ToString();
        HungerCount.text = hungerAmount.ToString();
    }

    public void addMoney()
    {
        moneyAmount += 10;
    }

    public void removeHunger()
    {
        hungerAmount -= 10;
    }

}
