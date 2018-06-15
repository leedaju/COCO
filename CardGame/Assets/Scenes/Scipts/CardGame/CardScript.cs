using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour {

    public string CardType;

    public bool istitle;
    public bool isNottitle;

    bool mouseOver = false;
    

    public Color startColor ;
    public Color mouseOverColor;
    public Color SelectedColor;
    

    public bool isSelectedAstitle = false;

    void Start()
    {
        if(this.CompareTag("Cards_title"))
        {
            istitle = true;
        }else
        {
            isNottitle = true;
        }
    }

    

    void OnMouseDown()
    {
        
        if (istitle)
        {
            if(CardType == "bool")
            {

                SceneController.Instance.ResetAllBool();
                SceneController.Instance.GetBooltitle_true();
                GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                SceneController.Instance.GetBool_true();
                

            }
            else if(CardType == "char")
            {
                SceneController.Instance.ResetAllBool();
                SceneController.Instance.GetChartitle_true();
                GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                SceneController.Instance.GetChar_true();

            }
            else if(CardType == "float")
            {
                SceneController.Instance.ResetAllBool();
                SceneController.Instance.GetFloattitle_true();
                GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                SceneController.Instance.GetFloat_true();

            }
            else if(CardType == "int")
            {
                SceneController.Instance.ResetAllBool();
                SceneController.Instance.GetInttitle_true();
                GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                SceneController.Instance.GetInt_true();

            }
            else if(CardType == "string")
            {
                SceneController.Instance.ResetAllBool();
                SceneController.Instance.GetStringtitle_true();
                GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                SceneController.Instance.GetString_true();

            }
        }else if(isNottitle)
        {
            if(CardType == "bool")
            {
                if(SceneController.Instance.GetBool_title() == true)
                {

                    SceneController.Instance.DeleteBoolCard_True();
                    SceneController.Instance.ResetAllBool();
                    
                    Destroy(this.gameObject);                    
                }else if(SceneController.Instance.GetBool_title() == false)
                {
                    SceneController.Instance.ResetAllBool();
                }
            }else if(CardType == "char")
            {
                if(SceneController.Instance.GetChar_title() == true)
                {
                    SceneController.Instance.DeleteCharCard_True();
                    SceneController.Instance.ResetAllBool();
                    
                    Destroy(this.gameObject);
                }else if(SceneController.Instance.GetChar_title() == false)
                {
                    SceneController.Instance.ResetAllBool();
                }
            }else if(CardType == "float")
            {
                if(SceneController.Instance.GetFloat_title() == true)
                {
                    SceneController.Instance.DeleteFloatCard_True();
                    SceneController.Instance.ResetAllBool();
                    
                    Destroy(this.gameObject);
                }else if(SceneController.Instance.GetFloat_title() == false)
                {
                    SceneController.Instance.ResetAllBool();
                }
            }else if(CardType == "int")
            {
                if(SceneController.Instance.GetInt_title() == true)
                {
                    SceneController.Instance.DeleteIntCard_True();
                    SceneController.Instance.ResetAllBool();
                    
                    Destroy(this.gameObject);
                }else if(SceneController.Instance.GetInt_title() == false)
                {
                    SceneController.Instance.ResetAllBool();
                }
            }else if(CardType == "string")
            {
                if(SceneController.Instance.GetString_title() == true)
                {
                    SceneController.Instance.DeleteStringCard_True();
                    SceneController.Instance.ResetAllBool();
                    
                    Destroy(this.gameObject);
                }else if(SceneController.Instance.GetString_title() == false)
                {
                    SceneController.Instance.ResetAllBool();
                }
            }
        }
    }

    void Update()
    {
        if (istitle)
        {
            if(CardType == "bool")
            {
                if (SceneController.Instance.GetDeleteBoolCard() == true)
                {
                    Destroy(this.gameObject);
                }
            }else if(CardType == "char")
            {
                if (SceneController.Instance.GetDeleteCharCard() == true)
                {
                    Destroy(this.gameObject);
                }
            }else if(CardType == "float")
            {
                if (SceneController.Instance.GetDeleteFloatCard() == true)
                {
                    Destroy(this.gameObject);
                }
            }else if(CardType == "int")
            {
                if (SceneController.Instance.GetDeleteIntCard() == true)
                {
                    Destroy(this.gameObject);
                }
            }else if(CardType == "string")
            {
                if (SceneController.Instance.GetDeleteStringCard() == true)
                {
                    Destroy(this.gameObject);
                }
            }
            
        }
        
       if(SceneController.Instance.GetBool() == true)
        {
            if(CardType == "bool")
            {
                if(istitle)
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                }
                
            }
            
        }
        if (SceneController.Instance.GetChar() == true)
        {
            if(CardType == "char")
            {
                if (istitle)
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                }
            }
        }
        if (SceneController.Instance.GetInt() == true)
        {
            if(CardType == "int")
            {
                if (istitle)
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                }
            }
            
        }
        if (SceneController.Instance.GetString() == true)
        {
            if(CardType == "string")
            {
                if (istitle)
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                }
            }
            
        }
        if (SceneController.Instance.GetFloat() == true)
        {
            if(CardType == "float")
            {
                if (istitle)
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", SelectedColor);
                }
            }
        }

       if(SceneController.Instance.GetBool() == false)
        {
            if (CardType == "bool")
            {
                if(gameObject.CompareTag("Cards_title"))
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", startColor);
                }
                
            }
        }
        if (SceneController.Instance.GetChar() == false)
        {
            if(CardType == "char")
            {
                if (gameObject.CompareTag("Cards_title"))
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", startColor);
                }
            }
        }
        if (SceneController.Instance.GetInt() == false)
        {
            if (CardType == "int")
            {
                if (gameObject.CompareTag("Cards_title"))
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", startColor);
                }
            }

        }
        if (SceneController.Instance.GetString() == false)
        {
            if (CardType == "string")
            {
                if (gameObject.CompareTag("Cards_title"))
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", startColor);
                }
            }

        }
        if (SceneController.Instance.GetFloat() == false)
        {
            if (CardType == "float")
            {
                if (gameObject.CompareTag("Cards_title"))
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", startColor);
                }
            }
        }
       if(mouseOver)
        {
            if(CardType == "bool")
            {
                if(SceneController.Instance.GetBool() == false)
                {
                    GetComponent<SpriteRenderer>().material.SetColor("_Color", mouseOverColor);
                }
            }else if (CardType == "char")
            {
                GetComponent<SpriteRenderer>().material.SetColor("_Color", mouseOverColor);
            }else if(CardType == "int")
            {
                GetComponent<SpriteRenderer>().material.SetColor("_Color", mouseOverColor);
            }else if(CardType == "string")
            {
                GetComponent<SpriteRenderer>().material.SetColor("_Color", mouseOverColor);
            }else if(CardType == "float")
            {
                GetComponent<SpriteRenderer>().material.SetColor("_Color", mouseOverColor);
            }
        }

       
    }

    void OnMouseEnter()
    {
        mouseOver = true;
        GetComponent<SpriteRenderer>().material.SetColor("_Color", mouseOverColor);
    }

    void OnMouseExit()
    {
        
        
            mouseOver = false;
            GetComponent<SpriteRenderer>().material.SetColor("_Color", startColor);      
           
    }




}
