using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int leftScore = 0;
    int rightScore = 0;

    void Goal()
    {
        leftScore += 1;
        rightScore += 1;

        
    }
}
