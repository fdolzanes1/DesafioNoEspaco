﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gerador : MonoBehaviour
{
    [SerializeField]
    private Transform alvo;
    [SerializeField]
    private GameObject prefabInimigo;
    [SerializeField]
    private float tempo;
    [SerializeField]
    private float raio;

    private void Start()
    {
        //StartCoroutine(this.IniciarGeracao());
        InvokeRepeating("Instanciar", 0f, this.tempo);
    }

    /**
     * private IEnumerator IniciarGeracao()
    {
        while (true)
        {
            yield return new WaitForSeconds(this.tempo);
            this.Instanciar();
        }
    }
    */

    private void Instanciar()
    {
        var inimigo = GameObject.Instantiate(this.prefabInimigo);
        this.DefinirPosicaoInimigo(inimigo);
        //inimigo vai seguir a posicao do alvo (jogador)
        inimigo.GetComponent<Seguir>().SetAlvo(this.alvo);
    }

    private void DefinirPosicaoInimigo(GameObject inimigo)
    {
        var posicaoAleatoria = new Vector3(
                        Random.Range(-this.raio, this.raio),
                        Random.Range(-this.raio, this.raio),
                        0);

        var posicaoInimigo = this.transform.position + posicaoAleatoria;
        inimigo.transform.position = posicaoInimigo;
    }
}
