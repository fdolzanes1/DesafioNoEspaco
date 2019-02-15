using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Collections.ObjectModel;


public class Ranking : MonoBehaviour
{
    private static string NOME_DO_ARQUIVO = "Ranking.json";
    [SerializeField]
    private List<Colocado> listaDeColocados;
    private string caminhoParaOArquivo;

    private void Awake()
    {
        this.caminhoParaOArquivo = Path.Combine(Application.persistentDataPath, NOME_DO_ARQUIVO);

        if (File.Exists(this.caminhoParaOArquivo))
        {
            var textoJSON = File.ReadAllText(this.caminhoParaOArquivo);
            JsonUtility.FromJsonOverwrite(textoJSON, this);
        }
        else
        {
            this.listaDeColocados = new List<Colocado>();
        }
    }

    public void AdicionarPontuacao(int pontos, string nome)
    {
        var novoColocado = new Colocado(nome, pontos);
        this.listaDeColocados.Add(novoColocado);
        this.SalvarRanking();
    }

    public int Quantidade()
    {
        return this.listaDeColocados.Count;
    }

    public ReadOnlyCollection<Colocado> GetPontos()
    {
        return this.listaDeColocados.AsReadOnly();
    }

    // salvando informacoes do ranking no json
    public void SalvarRanking()
    {
        var textoJson = JsonUtility.ToJson(this);

        File.WriteAllText(this.caminhoParaOArquivo, textoJson);
        //Debug.Log(Application.persistentDataPath);
    }
}

[System.Serializable]
public class Colocado
{
    public string nome;
    public int pontos; 


    public Colocado (string nome, int pontos)
    {
        this.nome = nome;
        this.pontos = pontos;
    }
}
