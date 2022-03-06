using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraProgresso : MonoBehaviour
{
    private StatusBarra _statusBarra;
    public GameObject _barraDeProgresso;
    public float _maxProgresso;
    public float _progressoAtual;
    public float _speed;

    void Start()
    {
        _statusBarra = this.gameObject.GetComponent<StatusBarra>();
    }

    void Update()
    {
        _barraDeProgresso.transform.localScale = new Vector3(_statusBarra.PegarTamanhoBarra(_progressoAtual, _maxProgresso) * 100, 0.3f, 0.3f);
        if (_progressoAtual < _maxProgresso)
            _progressoAtual += Time.deltaTime * _speed;
        if (_progressoAtual >= _maxProgresso)
            _progressoAtual = 97f;
    }
    public void ZeraBarra()
    {
        _progressoAtual = 0f;
    }
    public int StatusBarra()
    {
        return _statusBarra.PegarPorcentagemBarra(_progressoAtual, _maxProgresso, 100);
    }
}
