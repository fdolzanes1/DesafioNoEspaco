﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NovaPontuacao : MonoBehaviour
{
    //[SerializeField]
    public TextoDinamico textoPontuacao;
    private Pontuacao pontuacao;
    [SerializeField]
    private Ranking ranking;
    private int id;

    private void Start()
    {
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
        var totalDePontos = -1;

        if (this.pontuacao != null)
        {
            totalDePontos = this.pontuacao.Pontos;
        }
        this.textoPontuacao.AtualizarTexto(totalDePontos);
        this.id = this.ranking.AdicionarPontuacao(totalDePontos, "Nome");
        
    }

    public void AlterarNome (string nome)
    {
        this.ranking.AlterarNome(nome, this.id);
    }

}
