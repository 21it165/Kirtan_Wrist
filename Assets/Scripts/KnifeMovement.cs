using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeMovement : MonoBehaviour
{
    public GameObject Carrot;
    public Text text;

    private Animator CarrotAnimator;
    private Vector3 CurrentPosition;
    private float CutStartTime;
    private bool cutting;
    private int CutCount;

   // private bool LeftArrowEnable;
    // Start is called before the first frame update
    void Start()
    {
        cutting = false;
        CutCount = 0;
        CarrotAnimator = Carrot.GetComponent<Animator>();
        //LeftArrowEnable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(CutCount<4){
            text.text = "Press DownArrow To Cut"; 
        }else{
            text.text = "Press LeftArrow To Put In Bakset";
        }
       // CurrentPosition = transform.position;

        if(Input.GetKeyDown(KeyCode.DownArrow) && !cutting && CutCount<4){
            Cut();
            CurrentPosition = transform.position;
            //transform.position = CurrentPosition; 
        }
        if(cutting){
            transform.position += new Vector3(0f, -0.05f, 0f);
            if(Time.time - CutStartTime >= 1.7f){
                if(CutCount == 1){
                    CarrotAnimator.SetTrigger("Cut1Trigger");
                }else if(CutCount == 2){
                    CarrotAnimator.SetTrigger("Cut2Trigger");
                }else if(CutCount == 3){
                    CarrotAnimator.SetTrigger("Cut3Trigger");
                }else if(CutCount == 4){
                    CarrotAnimator.SetTrigger("Cut4Trigger");
                    CarrotAnimator.SetTrigger("Cut5Trigger");
                }
                cutting = false;
                transform.position = CurrentPosition + new Vector3(2.5f, 0f, 0f);
            }
        }
        

        if(CutCount == 4 && !cutting){
            if(Input.GetKeyDown(KeyCode.LeftArrow)){
                 PutCarrotInBasket();
             }
        }
       
    }

    void Cut(){
       
        CutStartTime = Time.time;
        cutting = true;
        CutCount += 1;
                 
    }

    void PutCarrotInBasket(){
        CarrotAnimator.SetTrigger("PutCarrotInBasket");
    }
}
