using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("Variables para mover al jugador")]
    public float x;
    public float y;
    public float z;
    public bool isJumping;
    [Header("Variable spara mover al jugador 2")]
    public float x2;
    public float y2;
    public float z2;

    [Header("Jugadores")]
    public GameObject player;
    public GameObject player2;


    
    
    void Start()
    {
        x = player.transform.position.x; y = player.transform.position.y; z = player.transform.position.z;
        player.transform.position = new Vector3(x,y,z);
        

        x2 = player2.transform.position.x; y2 = player2.transform.position.y; z2= player2.transform.position.z;
        player2.transform.position = new Vector3(x2,y2,z2);


    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer1();
        MovementPLayer2();
    }
    public void MovementPlayer1()
    {

        if(Input.GetKeyDown(KeyCode.W)) 
        {
            x += 1;
            player.transform.position = new Vector3(x,y, z);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            x -= 1;
            player.transform.position = new Vector3(x, y, z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            z -= 1;
            player.transform.position = new Vector3(x, y, z);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            z += 1;
            player.transform.position = new Vector3(x, y, z);
        }
        
    }
    public void MovementPLayer2()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            x2 += 1;
            player2.transform.position = new Vector3(x2, y2, z2);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            x2 -= 1;
            player2.transform.position = new Vector3(x2, y2, z2);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            z2 -= 1;
            player2.transform.position = new Vector3(x2, y2, z2);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            z2 += 1;
            player2.transform.position = new Vector3(x2, y2, z2);
        }
    }
}
