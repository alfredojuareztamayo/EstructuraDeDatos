using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct MeleeWeapon
{
   public enum TYPEWEAPON
    {
        Hammer,
        Scythe,
        Machete
    }

    public int dmg;
    public int lvl;
    public string name;

    public TYPEWEAPON type;
    public MeleeWeapon(int dmg, int lvl, string name, TYPEWEAPON type)
    {
       this.dmg = dmg;
       this.lvl = lvl;
       this.name = name;
       this.type = type;
    }
}
public class ScrtucTest : MonoBehaviour
{
    public List<MeleeWeapon> HammerList= new List<MeleeWeapon>();
    public List<MeleeWeapon> ScytheList = new List<MeleeWeapon>();
    public List<MeleeWeapon> MacheteList = new List<MeleeWeapon>();

    public enum TYPETOCONSOLE
    {
        name,
        dmg,
        lvl,
        Weapon
    }
     public TYPETOCONSOLE Console;

    MeleeWeapon[] WeaponsArray = new MeleeWeapon[]
    {
        new MeleeWeapon(10,5,"Chikiro", MeleeWeapon.TYPEWEAPON.Hammer),
        new MeleeWeapon(20,10,"BabyCry", MeleeWeapon.TYPEWEAPON.Hammer),
        new MeleeWeapon(15,8,"Tokyo", MeleeWeapon.TYPEWEAPON.Scythe),
        new MeleeWeapon(1,9,"UltraMegaArmaDestructor", MeleeWeapon.TYPEWEAPON.Scythe),
        new MeleeWeapon(70,10,"Boom", MeleeWeapon.TYPEWEAPON.Scythe),
        new MeleeWeapon(20,2,"GatoGalactico", MeleeWeapon.TYPEWEAPON.Machete),
        new MeleeWeapon(15,3,"F", MeleeWeapon.TYPEWEAPON.Machete),
        new MeleeWeapon(15,4,"JhonCena", MeleeWeapon.TYPEWEAPON.Machete),
        new MeleeWeapon(8,5,"Spy", MeleeWeapon.TYPEWEAPON.Machete),
        new MeleeWeapon(5,10,"SoyMaloCOnLosNombres", MeleeWeapon.TYPEWEAPON.Hammer)

    };

    public void OrdenarPorLVL(MeleeWeapon[] arreglo)
    {
  

        for (int i = 0; i < arreglo.Length; i++)
        {

            for (int j = 0; j < arreglo.Length - 1; j++)
            {

                if (arreglo[j].lvl >= arreglo[j + 1].lvl) continue;
                MeleeWeapon swap = arreglo[j];
                arreglo[j] = arreglo[j + 1];
                arreglo[j + 1] = swap;
            }

        }
    }
    public void OrdenarPorDMG(MeleeWeapon[] arreglo)
    {

        for (int i = 0; i < arreglo.Length; i++)
        {

            for (int j = 0; j < arreglo.Length - 1; j++)
            {

                if (arreglo[j].dmg >= arreglo[j + 1].dmg) continue;
                MeleeWeapon swap = arreglo[j];
                arreglo[j] = arreglo[j + 1];
                arreglo[j + 1] = swap;
            }

        }
        
    }
    public void OrdenarPorTypeWeapon(MeleeWeapon[] arreglo)
    {
        foreach (MeleeWeapon item in arreglo)
        {
            switch (item.type)
            {
                case MeleeWeapon.TYPEWEAPON.Hammer:  
                        HammerList.Add(item);
                break;

                case MeleeWeapon.TYPEWEAPON.Scythe: 
                    ScytheList.Add(item);
                break;

                case MeleeWeapon.TYPEWEAPON.Machete: 
                    MacheteList.Add(item);
                break;
            }
        }    
    }

    public void OrdenarPorAlfabeto(MeleeWeapon[] arreglo)
    {

        for (int i = 0; i < arreglo.Length; i++)
        {

            for (int j = 0; j < arreglo.Length - 1; j++)
            {
                
                if (string.Compare(arreglo[j].name, arreglo[j + 1].name) >= 0) continue;
                MeleeWeapon swap = arreglo[j];
                arreglo[j] = arreglo[j + 1];
                arreglo[j + 1] = swap;
            }

        }

    }

   
    public void ShowArrayString(MeleeWeapon[] arreglo, TYPETOCONSOLE type)
    {
        switch (type)
        {
            case TYPETOCONSOLE.name:
               
                for (int i = 0; i < arreglo.Length; i++)
                {
                   string tempString = arreglo[i].name.ToString();
                    Debug.Log(tempString);
                }
                break;
            case TYPETOCONSOLE.lvl:
                for (int i = 0; i < arreglo.Length; i++)
                {
                    string tempString = arreglo[i].lvl.ToString();
                    Debug.Log(tempString);
                }
                break;

            case TYPETOCONSOLE.dmg:
                for (int i = 0; i < arreglo.Length; i++)
                {
                    string tempString = arreglo[i].dmg.ToString();
                    Debug.Log(tempString);
                }
                break;

            
        }

    }
    public void buttonNames()
    {
        OrdenarPorAlfabeto(WeaponsArray);
        ShowArrayString(WeaponsArray, TYPETOCONSOLE.name);
    }
    public void buttonLVL()
    {
        OrdenarPorAlfabeto(WeaponsArray);
        ShowArrayString(WeaponsArray, TYPETOCONSOLE.lvl);
    }
    public void buttonDmg()
    {
        OrdenarPorAlfabeto(WeaponsArray);
        ShowArrayString(WeaponsArray, TYPETOCONSOLE.dmg);
    }
}
