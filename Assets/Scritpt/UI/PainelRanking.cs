using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelRanking : MonoBehaviour
{
    [SerializeField]
    private Ranking ranking;
    [SerializeField]
    private GameObject prefabColocacao; 

    void Start()
    {
        var quantidade = this.ranking.Quantidade();
        
        for ( var i=0; i<quantidade; i++ )
        {
            GameObject.Instantiate(this.prefabColocacao, this.transform);
        }
    }
}
