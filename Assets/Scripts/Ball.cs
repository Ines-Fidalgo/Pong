using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 8f;


    bool BolaLancada;
    float cronometro = 2.0f;

    float AlturaCamara = 3f;
    float LarguraCamara = 6.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        if (Random.value < 0.5f)
        {
            GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitSphere;
        }
    }

    // Update is called once per frame
    void Update()
    {
        cronometro -= Time.deltaTime;

        if (cronometro > 0.0f)
        {
            BolaLancada = false;
        }

        if (cronometro <= 0.0f)
        {
            BolaLancada = true;
        }



        if (BolaLancada == false)
        {
            Vector3 positionAux = transform.position;
            positionAux.x = 0.0f;
            positionAux.y = 0.0f;
            positionAux.z = 0.0f;
            transform.position = positionAux;
        }

        else
        {
            SegundoUpdate();
        }

    }
    void SegundoUpdate()
    {
        Vector2 positionAux = transform.position;

        GetComponent<Rigidbody2D>().position = positionAux;

        positionAux.x = Mathf.Clamp(positionAux.x, AlturaCamara + LarguraCamara, -AlturaCamara - LarguraCamara);
        positionAux.y = Mathf.Clamp(positionAux.y, AlturaCamara + LarguraCamara, -AlturaCamara - LarguraCamara);

        // Às vezes resulta, às vezes não...  ¯\_(ツ)_/¯
    }
}


