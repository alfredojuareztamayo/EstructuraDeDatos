using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Board superJuego = new Board();
    void Start()
    {
        superJuego.GenerateBoard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowArray()
    {
        Debug.Log("Hola");
        superJuego.PrintArray();

    }
}
