using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    [SerializeField]
    private Transform alvo;

    void Update()
    {
        var deslocamento = alvo.position - this.transform.position;
        deslocamento = deslocamento.normalized;
        this.transform.position += deslocamento * Time.deltaTime;
    }
}
