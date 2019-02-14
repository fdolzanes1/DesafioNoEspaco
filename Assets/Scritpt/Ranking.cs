using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    private List<int> pontos;   

    private void Awake()
    {
        this.pontos = new List<int>();
    }

    public void AdicionarPontuacao(int pontos)
    {
        this.pontos.Add(pontos);
        this.SalvarRanking();
    }

    public void SalvarRanking()
    {
        PlayerPrefs.SetInt("pontuacao",);


    }
}
