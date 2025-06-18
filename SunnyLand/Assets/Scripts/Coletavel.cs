using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coletavel : MonoBehaviour
{
    public ParticleSystem efeito;
    public TMP_Text texto_pontuacao;
    int points = 0;
    private int pontos = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Jogo começou! Você tem: \n" + pontos +  "pontos!" );
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Jogo Rodando!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            Debug.Log("Colidiu!");
            other.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
            Instantiate(efeito, transform.position, Quaternion.identity);
            points++;
            texto_pontuacao.text = "Pontos:" + points.ToString();
            Destroy(gameObject);
        }
    }
}
