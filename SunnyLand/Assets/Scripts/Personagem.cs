using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome = "Blublu";
    private int vida = 3;
    public float velocidade = 2.5f;
    private bool vivo = true;
    private Rigidbody2D rb;
    public float novaGravidade = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Seu Nome é:" + nome + "\n Você tem:" + vida + "pontos de vida!"+
            "\n Sua Velocidade é de:" + velocidade + "\n Está vivo?" + vivo);
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
