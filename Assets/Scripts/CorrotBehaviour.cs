using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrotBehaviour : MonoBehaviour
{
    public GameObject c1;
     public GameObject c2;
     public GameObject c3;
     public GameObject c4;
     public GameObject c5;
     public GameObject c1New;
     public GameObject c2New;
     public GameObject c3New;
     public GameObject c4New;
     public GameObject c5New;

    public GameObject c1NewBakset;
    public GameObject c2NewBakset;
    public GameObject c3NewBakset;
    public GameObject c4NewBakset;
    public GameObject c5NewBakset;

    // Start is called before the first frame update

    public void AdjustC1(){
        c1.SetActive(false);
        c1New.SetActive(true);
    } 

    public void AdjustC2(){
        c2.SetActive(false);
        c2New.SetActive(true);
    }
    public void AdjustC3(){
        c3.SetActive(false);
        c3New.SetActive(true);
    }

    public void AdjustC4(){
        c4.SetActive(false);
        c4New.SetActive(true);
    }

    public void AdjustC5(){
        c5.SetActive(false);
        c5New.SetActive(true);
    }

    public void PutInBasket(){
        c1New.SetActive(false);
        c2New.SetActive(false);
        c3New.SetActive(false);
        c4New.SetActive(false);
        c5New.SetActive(false);
        c1NewBakset.SetActive(true);
        c2NewBakset.SetActive(true);
        c3NewBakset.SetActive(true);
        c4NewBakset.SetActive(true);
       c5NewBakset.SetActive(true);
    }
}
