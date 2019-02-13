using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDePausa : MonoBehaviour
{
    [SerializeField]
    private GameObject painelPause;
    
    private void Update()
    {
        if (this.EstaoTocandoNaTela())
        {
            this.ContinuarJogo();
        } 
        else
        {
            this.PararJogo();
        }
        
    }

    private void ContinuarJogo()
    {
        this.painelPause.SetActive(false);
        this.MudarEscalaDeTempo(1);
    }

    private void PararJogo()
    {
        this.painelPause.SetActive(true);
        this.MudarEscalaDeTempo(0.1f);

    }

    private bool EstaoTocandoNaTela()
    {
        //return Input.touchCount > 0;
        return Input.anyKey;
    }

    private void MudarEscalaDeTempo(float escala)
    {
        Time.timeScale = escala;
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }

}
