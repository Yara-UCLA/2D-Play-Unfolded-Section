using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Token_Count : MonoBehaviour
{
    private List<GameObject> _tokens = new List<GameObject>();
    private List<GameObject> _collected = new List<GameObject>();
    private int _counter;
    public TMP_Text _counterUI;

    private void Start()
    {
        Transform[] children = gameObject.GetComponentsInChildren<Transform>();

        for(var i=0; i< children.Length; i++)
        {
            _tokens.Add(children[i].gameObject);
        }
    }

    void Update()
    {
        for (var i = 0; i < _tokens.Count; i++)
        {
            if (_tokens[i].activeInHierarchy == false)
            {
                _collected.Remove(_tokens[i]);
                _collected.Add(_tokens[i]);
            }
        }

        _counter = _collected.Count;
        _counterUI.text = _counter.ToString();
    }
}
