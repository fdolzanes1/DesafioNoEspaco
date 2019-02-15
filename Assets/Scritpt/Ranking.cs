using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections.ObjectModel;


public class Ranking : MonoBehaviour
{
    private static string NOME_DO_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<int> pontos;
    private string caminhoParaOArquivo;

    private void Awake()
    {
        this.caminhoParaOArquivo = Path.Combine(Application.persistentDataPath, NOME_DO_ARQUIVO);
        var textoJSON = File.ReadAllText(this.caminhoParaOArquivo);
        JsonUtility.FromJsonOverwrite(textoJSON, this);

    }

    public void AdicionarPontuacao(int pontos)
    {
        this.pontos.Add(pontos);
        this.SalvarRanking();
    }

    public int Quantidade()
    {
        return this.pontos.Count;
    }

    public ReadOnlyCollection<int> GetPontos()
    {
        return this.pontos.AsReadOnly();
    }

    public void SalvarRanking()
    {
        var textoJson = JsonUtility.ToJson(this);

        File.WriteAllText(this.caminhoParaOArquivo, textoJson);
        Debug.Log(Application.persistentDataPath);
    }
}
