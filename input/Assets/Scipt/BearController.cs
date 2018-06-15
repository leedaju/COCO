using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearController : MonoBehaviour
{
    GameObject Slot001;
    GameObject Slot002;
    GameObject Slot003;
    GameObject Slot004;

    GameObject input;
    GameObject right_p;
    GameObject blank1;
    GameObject left_p;
    GameObject int_type;
    GameObject blank2;
    GameObject blank3;
    GameObject put;
    GameObject float_type;

    GameObject bear;
    GameObject question;
    GameObject flag;
    GameObject bear_up;

    Rigidbody2D rigid2D;
    float jumpforce1 = 200.0f;


    float walkForce = 87.0f;
    //float MaxWalkSpeed=2.0f;
    int count = 0;

    void jump()
    {
        this.rigid2D.AddForce(new Vector2(this.walkForce, this.jumpforce1));
        question.transform.Translate(1.25f, 0.5f, 0);

    }

    // Use this for initialization
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.Slot001 = GameObject.Find("Slot001");
        this.Slot002 = GameObject.Find("Slot002");
        this.Slot003 = GameObject.Find("Slot003");
        this.Slot004 = GameObject.Find("Slot004");

        this.input = GameObject.Find("input");
        this.right_p = GameObject.Find("right_p");
        this.blank1 = GameObject.Find("blank1");
        this.left_p = GameObject.Find("left_p");
        this.int_type = GameObject.Find("int_type");
        this.blank2 = GameObject.Find("blank2");
        this.blank3 = GameObject.Find("blank3");
        this.put = GameObject.Find("put");
        this.float_type = GameObject.Find("float_type");

        this.bear = GameObject.Find("bear");
        this.question = GameObject.Find("question");
		this.flag = GameObject.Find ("flag");
        
        question.SetActive(false);
        

    }



    // Update is called once per frame
    void Update()
    {

        LoadData load = GameObject.Find("GameObject").GetComponent<LoadData>();
        int a = load.i;

        if (a == 0)
        {
            if (count == 0)
            {
                // 프린트의 위치상태 == 슬롯의 위치 상태가 같아지고 &&
                if (this.int_type.transform.position == this.Slot001.transform.position && count == 0)
                {
                    question.SetActive(false); // 보여지고 안보여지고
                    count++;
                    jump();
                }
                else if
                  (this.input.transform.position == this.Slot001.transform.position ||
                         this.right_p.transform.position == this.Slot001.transform.position ||
                         this.blank1.transform.position == this.Slot001.transform.position ||
                         this.left_p.transform.position == this.Slot001.transform.position ||
                         this.blank2.transform.position == this.Slot001.transform.position ||
                         this.blank3.transform.position == this.Slot001.transform.position ||
                         this.put.transform.position == this.Slot001.transform.position ||
                        this.float_type.transform.position == this.Slot001.transform.position)
                {

                    question.SetActive(true);
                }

            }
            if (this.left_p.transform.position == this.Slot002.transform.position && count == 1)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.input.transform.position == this.Slot002.transform.position ||
                 this.right_p.transform.position == this.Slot002.transform.position ||
                 this.blank1.transform.position == this.Slot002.transform.position ||
                 this.int_type.transform.position == this.Slot002.transform.position ||
                 this.blank2.transform.position == this.Slot002.transform.position ||
                 this.blank3.transform.position == this.Slot002.transform.position ||
                 this.put.transform.position == this.Slot002.transform.position ||
                this.float_type.transform.position == this.Slot002.transform.position)
            {

                question.SetActive(true);
            }




            if (this.input.transform.position == this.Slot003.transform.position && count == 2)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if
                (this.right_p.transform.position == this.Slot003.transform.position ||
                 this.blank1.transform.position == this.Slot003.transform.position ||
                 this.left_p.transform.position == this.Slot003.transform.position ||
                 this.int_type.transform.position == this.Slot003.transform.position ||
                 this.blank2.transform.position == this.Slot003.transform.position ||
                 this.blank3.transform.position == this.Slot003.transform.position ||
                 this.put.transform.position == this.Slot003.transform.position ||
                this.float_type.transform.position == this.Slot003.transform.position)
            {
                question.SetActive(true);
            }



            if (this.right_p.transform.position == this.Slot004.transform.position && count == 3)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.input.transform.position == this.Slot001.transform.position ||
                     this.blank1.transform.position == this.Slot001.transform.position ||
                       this.left_p.transform.position == this.Slot001.transform.position ||
                        this.int_type.transform.position == this.Slot003.transform.position ||
                        this.blank2.transform.position == this.Slot001.transform.position ||
                       this.blank3.transform.position == this.Slot001.transform.position ||
                       this.put.transform.position == this.Slot001.transform.position ||
                      this.float_type.transform.position == this.Slot001.transform.position)
            {

                question.SetActive(true);
            }
            if (count == 4)
            {
                Bump();
            }



        }
        else
        {

            if (count == 0)
            {
                // 프린트의 위치상태 == 슬롯의 위치 상태가 같아지고 &&
                if (this.blank1.transform.position == this.Slot001.transform.position && count == 0 || this.blank2.transform.position == this.Slot001.transform.position && count == 0 || this.blank3.transform.position == this.Slot001.transform.position && count == 0)
                {
                    question.SetActive(false); // 보여지고 안보여지고
                    count++;
                    jump();
                }
                else if
                  (this.input.transform.position == this.Slot001.transform.position ||
                         this.right_p.transform.position == this.Slot001.transform.position ||
                         this.int_type.transform.position == this.Slot001.transform.position ||
                         this.left_p.transform.position == this.Slot001.transform.position ||
                         this.put.transform.position == this.Slot001.transform.position ||
                        this.float_type.transform.position == this.Slot001.transform.position)
                {

                    question.SetActive(true);
                }

            }
            if (this.blank1.transform.position == this.Slot002.transform.position && count == 1 || this.blank2.transform.position == this.Slot002.transform.position && count == 1 || this.blank3.transform.position == this.Slot002.transform.position && count == 1)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.input.transform.position == this.Slot002.transform.position ||
                 this.right_p.transform.position == this.Slot002.transform.position ||
                 this.left_p.transform.position == this.Slot002.transform.position ||
                 this.int_type.transform.position == this.Slot002.transform.position ||
                 this.put.transform.position == this.Slot002.transform.position ||
                this.float_type.transform.position == this.Slot002.transform.position)
            {

                question.SetActive(true);
            }




            if (this.input.transform.position == this.Slot003.transform.position && count == 2)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if
                (this.right_p.transform.position == this.Slot003.transform.position ||
                 this.blank1.transform.position == this.Slot003.transform.position ||
                 this.left_p.transform.position == this.Slot003.transform.position ||
                 this.int_type.transform.position == this.Slot003.transform.position ||
                 this.blank2.transform.position == this.Slot003.transform.position ||
                 this.blank3.transform.position == this.Slot003.transform.position ||
                 this.put.transform.position == this.Slot003.transform.position ||
                this.float_type.transform.position == this.Slot003.transform.position)
            {
                question.SetActive(true);
            }



            if (this.blank1.transform.position == this.Slot004.transform.position && count == 3 || this.blank2.transform.position == this.Slot004.transform.position && count == 3 || this.blank3.transform.position == this.Slot004.transform.position && count == 3)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.input.transform.position == this.Slot004.transform.position ||
                 this.right_p.transform.position == this.Slot004.transform.position ||
                 this.left_p.transform.position == this.Slot004.transform.position ||
                 this.int_type.transform.position == this.Slot004.transform.position ||
                 this.put.transform.position == this.Slot004.transform.position ||
                this.float_type.transform.position == this.Slot004.transform.position)
            {

                question.SetActive(true);
            }

            if (count == 4)
            {
                Bump();
            }



        }

    }

    void Bump()
    {

       
        Vector2 p1 = this.flag.transform.position;
        Vector2 p2 = this.bear.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.3f;
        float r2 = 0.6f;

        if (d < r1 + r2)
        {

            //this.bear_up.SetActive (true);
            this.flag.transform.Translate(0, 0.05f, 0);
           


        }
    }

}


