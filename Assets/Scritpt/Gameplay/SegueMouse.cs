using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegueMouse : MonoBehaviour
{

    void Update()
    {
        //posicao do mouse em relacao a ponto de tela convertendo em Vector2
        var posicao = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);

        this.transform.position = posicao; 
    }
}
