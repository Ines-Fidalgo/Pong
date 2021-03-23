using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour

{
    [SerializeField]
    ScoreKeeper ScoreKeeper;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Boing!!");
        
        // Quando a Bola bater avisamos o score keeper
        // Se o método a cima for excutado a bola já bateu
        // precisamos apenas de avisar o Score keeper
        // Precisamos de criar uma ligação entre este códigoe e o do score keeper
    

    }

    
}
