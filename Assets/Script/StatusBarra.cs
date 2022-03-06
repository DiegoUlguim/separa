using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBarra : MonoBehaviour
{
    public float PegarTamanhoBarra(float _minValor, float _maxValor)
    {
        return _minValor / _maxValor;
    }
    public int PegarPorcentagemBarra(float _minValor, float _maxValor,int _fator)
    {
        return Mathf.RoundToInt(PegarTamanhoBarra(_minValor, _maxValor) * _fator);
    }
}
