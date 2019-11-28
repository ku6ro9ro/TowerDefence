using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarCtrl : MonoBehaviour {

    public Animator targetAnimator;

    Slider life;
    float damage = 0.5f;
    Animation anim;

    // Use this for initialization
    void Start () {
        life = GameObject.Find("Slider").GetComponent<Slider>();
        life.maxValue = 100;
        life.value = 100;
    }



    void Update()
    {
        if(life.value <= 0)
        {
            targetAnimator.SetTrigger("down");
            targetAnimator.SetTrigger("end");
            life.value = 100;
            
        }

        // HPゲージに値を設定
        life.value -= damage;
    }
}
