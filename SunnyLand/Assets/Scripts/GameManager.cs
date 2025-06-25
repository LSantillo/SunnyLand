using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Purchasing;


public class GameManager : MonoBehaviour
{
    public int coin = 0;
    public int vida = 5;

    public TMP_Text CoinText;
    public TMP_Text VidaText;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoints(int quantidade) {
        coin += quantidade;
        CoinText.text = coin.ToString();
    }
    public void RemoveLife(int quantidade) {
        vida -= quantidade;
        VidaText.text = vida.ToString();
    }
    public void Heal(int quantidade) {
        
        vida += quantidade;
        VidaText.text = vida.ToString();
    }
    public void Power(int quantidade)
    {
        vida += quantidade;
        
    }



}
