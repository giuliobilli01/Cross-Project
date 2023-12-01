using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float ballSpeed = 0.2f;
    public int multiplyer = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        // se il gioco va a 100 fps in un secondo update viene eseguita cento volte in un sec.
        // si risolve moltiplicando per deltatime che è l'intervallo in secondi tra un frame e il successivo.
        // in questo modo se il delta tra i frame è basso lo spazio percorso sarà uguale a quello di uno con 
        // delta maggiore sarà uguale. DI conseguenza è come scrivere la velocità in metri al sec. 
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(ballSpeed * Time.deltaTime * Vector3.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(ballSpeed * Time.deltaTime * -Vector3.right);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(ballSpeed * multiplyer * Time.deltaTime * Vector3.up);

        }
    }
}

