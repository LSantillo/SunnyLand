using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColetavelVida : MonoBehaviour
{
    public ParticleSystem efeito;
    public GameManager gameManager;
    private bool foiColetado = false;
    


    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Jogo Rodando!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (foiColetado) return;

        if (gameManager.vida == 5) return;

        if (other.CompareTag("Player")) {
            Debug.Log("Colidiu!");
            foiColetado = true;
            gameManager.Heal(1);
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
