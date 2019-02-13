using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDePausa : MonoBehaviour
{
    [SerializeField]
    private GameObject painelPause;

    private bool jogoEstaParado;

    private void Update()
    {
        if (this.EstaoTocandoNaTela())
        {
            if (this.jogoEstaParado)
            {
                this.ContinuarJogo();
            }
        }
        else
        {
            if (!this.jogoEstaParado)
            {
                this.PararJogo();
            }
        }

        /*if (this.EstaoTocandoNaTela())
        {
            this.ContinuarJogo();
        } 
        else
        {
            this.PararJogo();
        }*/

    }

    private void ContinuarJogo()
    {
        //this.painelPause.SetActive(false);
        //this.MudarEscalaDeTempo(1);
        StartCoroutine(this.EsperarEContinuarOJogo());
    }

    private IEnumerator EsperarEContinuarOJogo()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        this.MudarEscalaDeTempo(1);
        this.painelPause.SetActive(false);
        this.jogoEstaParado = false;
    }

    private void PararJogo()
    {
        this.painelPause.SetActive(true);
        this.MudarEscalaDeTempo(0.1f);
        this.jogoEstaParado = true;
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
