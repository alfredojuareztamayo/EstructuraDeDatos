using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board 
{
    const int boardRows = 10;
    const int boardColumns = 10;
    public Tile[,] tile { get; private set; } = new Tile[boardRows, boardColumns];
    public int BombNum { get; private set; } = 20;

    //tempBomb=10              tilesLeft=10  random=rand :V jaj
    public void GenerateBoard()
    {
        int tempBomb = BombNum;
        int tilesLeft = boardColumns * boardRows;
      
        for (int i = 0; i < boardRows; i++)
        {
            for (int j = 0; j < boardColumns; j++)
            {
                int random = Random.Range(0, 5);
                if(tilesLeft == tempBomb)
                {
                    tile[i, j] = new Tile(true);
                    tempBomb--;
                    tilesLeft--;
                }
                else
                {
                    if (tempBomb > 0 & random == 1)
                    {
                        tile[i, j] = new Tile(true);
                        tempBomb--;
                        tilesLeft--;
                    }
                    else
                    {
                        tile[i, j] = new Tile(false);
                       
                        tilesLeft--;
                    }
                }
                
            }
        }

    }

    public void PrintArray()
    {
        string printArray = "";
        for (int i = 0; i < boardRows; i++)
        {
            for (int j = 0; j < boardColumns; j++)
            {
               if(tile[i, j].BomboN)
                {
                    printArray += 'B';
                }
                else
                {
                    printArray += tile[i, j].BombsNear;
                }
                printArray += ',';
            }
            printArray += '\n';
        }
        Debug.Log(printArray);
    }

}
