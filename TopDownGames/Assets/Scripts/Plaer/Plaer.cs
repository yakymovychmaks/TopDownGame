using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Plaer : MonoBehaviour
{
    // [SerializeField] Bullet hits;
    [SerializeField] private int _whichPlaer = 0;

    public int selectPlaer => _whichPlaer;

    [SerializeField] private int _health = 100;
    public int Health => _health;

    [SerializeField] private TMP_Text _hpView;
    [SerializeField] private TMP_Text _score;
    public int Score = 0;
    

    public void SetHealth(int newValue) 
    {
         _health = newValue;
         _hpView.text = _health.ToString();
    }

    public void SetScore()
    {
        Score++;
        _score.text = Score.ToString();
    }

    void Update()
    {
        if(_health <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
