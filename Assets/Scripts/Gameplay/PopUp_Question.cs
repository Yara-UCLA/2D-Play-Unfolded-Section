using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Mechanics;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;

public class PopUp_Question : MonoBehaviour
{

    public GameObject _question;
    public PlayerController _player;

    Vector3 init_Pos;

    public void OnEnable()
    {
        init_Pos = _player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag( "Player"))
        {
            _question.SetActive(true);
            _player.enabled = false;
        }
    }

    public void WrongAnswer()
    {
        _question.SetActive(false);
        _player.enabled = true;
        var ev = Schedule<PlayerAnsweredWrong>();
        Debug.Log("Wrong Answer");
    }

    public void CorrectAnswer()
    {
        _question.SetActive(false);
        _player.enabled = true;
        Debug.Log("Correct Answer");
    }



}
