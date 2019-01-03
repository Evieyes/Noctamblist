using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingcontroller : MonoBehaviour {

    //private List<Object> test;
    //private Animator animator;
    public Animator anim;
    private bool isground;
    private int fetherbutton;
    private int fetherjump;
    private float xx;
    private float yy;
    private float zz;
    // Use this for initialization
    void Start()
    {

        this.anim.SetInteger("Fup", 1);
        this.anim.SetInteger("Fdown", 1);
        this.anim.SetInteger("turn1", 1);
        this.anim.SetInteger("Jump", 1);
        this.anim.SetInteger("Jump2", 1);
        isground = true;
        PlayerPrefs.SetInt("fetherbutton", 1);
        PlayerPrefs.SetInt("fetherjump", 1);
    }

    // Update is called once per frame
    void Update()
    {
        Isground();
        fetherbutton = PlayerPrefs.GetInt("fetherbutton");
        fetherjump= PlayerPrefs.GetInt("fetherjump");
        if (Input.GetKeyDown(KeyCode.D) && fetherbutton == 1)
        {
            this.anim.SetInteger("Fdown", 0);
            this.anim.SetInteger("Fup", 1);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherbutton", 1);
        }

        if (Input.GetKeyUp(KeyCode.D) && fetherbutton == 1)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 0);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherbutton", 1);
        }

        if (Input.GetKeyDown(KeyCode.D) && fetherbutton == 2)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 1);
            this.anim.SetInteger("turn1", 0);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherbutton", 1);
        }
        if (Input.GetKeyUp(KeyCode.D) && fetherbutton == 2)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 0);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherbutton", 1);
        }

        if (Input.GetKeyDown(KeyCode.A) && fetherbutton == 2)
        {
            this.anim.SetInteger("Fdown", 0);
            this.anim.SetInteger("Fup", 1);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherbutton", 2);
        }
        if (Input.GetKeyUp(KeyCode.A) && fetherbutton == 2)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 0);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherbutton", 2);
        }
        if (Input.GetKeyDown(KeyCode.A) && fetherbutton == 1)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 1);
            this.anim.SetInteger("turn1", 0);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherbutton", 2);
        }
        if (Input.GetKeyUp(KeyCode.A) && fetherbutton == 1)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 0);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherbutton", 2);

        }

        if (Input.GetKeyDown(KeyCode.S)&& !isground)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 1);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 0);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherjump", 1);
        }

        if (Input.GetKeyUp(KeyCode.S)&& !isground)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 1);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherjump", 1);

        }

        if (Input.GetKeyDown(KeyCode.W)&&isground)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 1);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 0);
            PlayerPrefs.SetInt("fetherjump", 0);
        }

        if (Input.GetKeyUp(KeyCode.W)&&isground)
        {
            this.anim.SetInteger("Fdown", 1);
            this.anim.SetInteger("Fup", 1);
            this.anim.SetInteger("turn1", 1);
            this.anim.SetInteger("Jump", 1);
            this.anim.SetInteger("Jump2", 1);
            PlayerPrefs.SetInt("fetherjump", 0);

        }

        if (!Isground()&&fetherjump==1)
        {
            Resety();
        }
        
    }

    public bool Isground()
    {
        yy = GameObject.Find("model").GetComponent<Transform>().position.y;
        if (yy < 0.45 && yy > -0.3)
        {
            isground = true;
           
        }
        else
        {
            isground = false;
        }
        return isground;
    }

    public void Resety()
    {
        xx = GameObject.Find("model").GetComponent<Transform>().position.x;
        yy = GameObject.Find("model").GetComponent<Transform>().position.y;
        zz = GameObject.Find("model").GetComponent<Transform>().position.z;

        AnimatorStateInfo stateinfo = this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
        if (!stateinfo.IsName("Idle_JumpDownHigh_Idle"))
        {
            GameObject.Find("model").GetComponent<Transform>().position = new Vector3(xx, 0, zz);
        }
       
        
    }
}
