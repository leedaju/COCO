using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearController : MonoBehaviour {

	GameObject p1;
	GameObject p2;
	GameObject p3;
	GameObject p4;
	GameObject Slot001;
	GameObject Slot002;
	GameObject Slot003;
	GameObject Slot004;
	GameObject bear;
	GameObject question;
	GameObject flag;

	Rigidbody2D rigid2D;
	float jumpforce1 = 200.0f;


	float walkForce = 87.0f;
	//float MaxWalkSpeed=2.0f;
	int count = 0;

	void jump(){
		this.rigid2D.AddForce (new Vector2(this.walkForce, this.jumpforce1));
		question.transform.Translate (1.25f, 0.5f, 0);

	}

	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D> ();
		this.p1 = GameObject.Find ("p1");
		this.Slot001 = GameObject.Find ("Slot001");
		this.p2 = GameObject.Find ("p2");
		this.Slot002 = GameObject.Find ("Slot002");
		this.p3 = GameObject.Find ("p3");
		this.Slot003 = GameObject.Find ("Slot003");
		this.p4 = GameObject.Find ("p4");
		this.Slot004 = GameObject.Find ("Slot004"); 
		this.bear = GameObject.Find ("bear");
		this.question = GameObject.Find ("question");
		this.flag = GameObject.Find ("flag");

		question.SetActive (false);

	}



    // Update is called once per frame
    void Update()
    {

        LoadDB load = GameObject.Find("GameObject").GetComponent<LoadDB>();
        int a = load.i;

        if (a == 0)
        {

            if (count == 0)
            {

                if (this.p2.transform.position == this.Slot001.transform.position && count == 0)
                {
                    question.SetActive(false);
                    count++;
                    jump();

                }
                else if (this.p1.transform.position == this.Slot001.transform.position ||
                         this.p3.transform.position == this.Slot001.transform.position ||
                         this.p4.transform.position == this.Slot001.transform.position)
                {

                    question.SetActive(true);
                }


            }

            if (this.p1.transform.position == this.Slot002.transform.position && count == 1)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.p2.transform.position == this.Slot002.transform.position ||
                        this.p3.transform.position == this.Slot002.transform.position ||
                     this.p4.transform.position == this.Slot002.transform.position)
            {

                question.SetActive(true);
            }




            if (this.p3.transform.position == this.Slot003.transform.position && count == 2)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.p1.transform.position == this.Slot003.transform.position ||
                     this.p2.transform.position == this.Slot003.transform.position ||
                     this.p4.transform.position == this.Slot003.transform.position)
            {

                question.SetActive(true);
            }



            if (this.p4.transform.position == this.Slot004.transform.position && count == 3)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.p1.transform.position == this.Slot004.transform.position ||
                     this.p2.transform.position == this.Slot004.transform.position ||
                     this.p3.transform.position == this.Slot004.transform.position)
            {

                question.SetActive(true);
            }
			if (count == 4) 
			{
				bump ();
			}
        }
        else if (a == 1)
        {
            if (count == 0)
            {

                if (this.p1.transform.position == this.Slot001.transform.position && count == 0)
                {
                    question.SetActive(false);
                    count++;
                    jump();

                }
                else if (this.p2.transform.position == this.Slot001.transform.position ||
                         this.p3.transform.position == this.Slot001.transform.position ||
                         this.p4.transform.position == this.Slot001.transform.position)
                {

                    question.SetActive(true);
                }


            }

            if (this.p3.transform.position == this.Slot002.transform.position && count == 1)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.p1.transform.position == this.Slot002.transform.position ||
                        this.p2.transform.position == this.Slot002.transform.position ||
                     this.p4.transform.position == this.Slot002.transform.position)
            {

                question.SetActive(true);
            }




            if (this.p4.transform.position == this.Slot003.transform.position && count == 2)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.p1.transform.position == this.Slot003.transform.position ||
                     this.p2.transform.position == this.Slot003.transform.position ||
                     this.p3.transform.position == this.Slot003.transform.position)
            {

                question.SetActive(true);
            }



            if (this.p2.transform.position == this.Slot004.transform.position && count == 3)
            {
                question.SetActive(false);
                count++;
                jump();
            }
            else if (this.p1.transform.position == this.Slot004.transform.position ||
                     this.p3.transform.position == this.Slot004.transform.position ||
                     this.p4.transform.position == this.Slot004.transform.position)
            {

                question.SetActive(true);
            }
			if (count == 4) 
			{
				bump ();
			}

        }


        }

	void bump(){

		LoadDB load = GameObject.Find("GameObject").GetComponent<LoadDB>();

		Vector2 p1 = this.flag.transform.position;
		Vector2 p2 = this.bear.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.3f;
		float r2 = 0.6f;

		if (d < r1 + r2) {

			//this.bear_up.SetActive (true);
			this.flag.transform.Translate (0, 0.03f, 0);
			StartCoroutine (load.LoadImg ());


		}
	}

    } 


