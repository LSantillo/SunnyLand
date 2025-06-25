using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColetavelPower : MonoBehaviour
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

        if (other.CompareTag("Player")) {
            Debug.Log("Colidiu!");
            foiColetado = true;
            // other.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
            gameManager.Power(1);
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
