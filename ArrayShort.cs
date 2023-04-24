using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayShort : MonoBehaviour
{
    int[] ArrayValue = new int[]
       {
         99,7,8,25,1,4,6,9,12,78

       };

    string[] ValoresArrayString = new string[]
    {

    };
    void Start()
    {
        OrdenarValores(ArrayValue);
        ShowArrayString(ArrayValue);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OrdenarValores(int[] arreglo)
    {
        int tempValor;
        int tempValor2;

        for (int i = 0; i < arreglo.Length; i++)
        {
           
            for (int j = 0; j < arreglo.Length -1 ; j++)
            {
                tempValor = arreglo[j];
                tempValor2 = arreglo[j+1];

                //Debug.Log(arreglo[j]);
                if (tempValor > tempValor2)
                {

                    arreglo[j] = tempValor2;
                    arreglo[j+1] = tempValor;
                    

                }
            }
           
        }
    }
    public void ShowArrayString(int[] arreglo)
    {
        string tempString;
        for (int i = 0; i < arreglo.Length; i++)
        {
            tempString = arreglo[i].ToString();
            Debug.Log(i + " Soy este valor: " + tempString);
        }
    }
}
