using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board 
{
    Stack<Tile> Bombitas = new();
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

        AddToStack();
    }

    public void PrintArray()
    {
        string printArray = " ";
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

    public void AddToStack()
    {
        for (int i = 0; i < boardRows; i++)
        {
            for (int j = 0; j < boardColumns; j++)
            {
                if (!tile[i, j].BomboN ) continue;
                Checksurroundind(i, j);
                
            }
        }
    }
    public void Checksurroundind(int i, int j)
    {
        for (int x = i-1; x <= i +1 ; x++)
        {
            for (int y = j-1; y <= j+1 ; y++)
            {
                if (x < 0) continue;
                if(y < 0) continue;
                if(x >= boardColumns) continue;
                if(y >= boardRows) continue;
                if (tile[x, y].BomboN) continue;
                Bombitas.Push(tile[x, y]);
                tile[x, y].Visible();
            }
        }
        AddCounterBombs();
    }
    public void AddCounterBombs()
    {
        while(Bombitas.Count > 0)
        {
            Bombitas.Pop().AddBombsNear();

        }     
    }
}
