using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            if ( i >= 5)
            {
                break;
            }

            var colocado = GameObject.Instantiate(this.prefabColocacao, this.transform);
            colocado.GetComponent<ItemRanking>().Configurar(i, "Ricardo", 929);
                
        }
    }
}
