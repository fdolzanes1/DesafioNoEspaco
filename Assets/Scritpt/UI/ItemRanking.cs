﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemRanking : MonoBehaviour
{
    [SerializeField]
    private Text textoColocado;

    [SerializeField]
    private Text textoNome;

    [SerializeField]
    private Text textoPontuacao;

    public void Configurar(int colocacao, string nome, int pontuacao)
    {
        this.textoColocado.text = colocacao.ToString();
        this.textoNome.text = nome;
        this.textoPontuacao.text = pontuacao.ToString();
    }
}
