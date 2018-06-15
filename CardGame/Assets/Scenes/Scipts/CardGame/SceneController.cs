using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour {

    private static SceneController instance;
    public static SceneController Instance
    {
        get
        {
            if (instance == null)
            {

                instance = FindObjectOfType<SceneController>();
                if (instance == null)
                {
                    GameObject container = new GameObject("SceneController");

                    instance = container.AddComponent<SceneController>();
                }

            }
            return instance;
        }
    }

    public GameObject PuasePanel;

    bool BooltitleSelected;
    bool ChartitleSelected;
    bool FloattitleSelected;
    bool InttitleSelected;
    bool StringtitleSelected;

    bool BoolSelected;
    bool CharSelected;
    bool FloatSelected;    
    bool IntSelected;
    bool StringSelected;

    bool DeleteBoolCard;
    bool DeleteCharCard;
    bool DeleteFloatCard;
    bool DeleteIntCard;
    bool DeleteStringCard;

    public bool isCardSelected;

    //Transfrom
    #region
    public Transform Card1_Pos;
    public Transform Card2_Pos;
    public Transform Card3_Pos;
    public Transform Card4_Pos;
    public Transform Card5_Pos;
    public Transform Card6_Pos;
    public Transform Card7_Pos;
    public Transform Card8_Pos;
    public Transform Card9_Pos;
    public Transform Card10_Pos;
    #endregion
            
    public GameObject[] bool_cards;
    public GameObject[] char_cards;
    public GameObject[] float_cards;
    public GameObject[] int_cards;
    public GameObject[] string_cards;

    int bool_int;
    int char_int;
    int float_int;
    int int_int;
    int string_int;

    public GameObject[] title_Cards;
    int RandomInt1;
    int RandomInt2;
    int RandomInt3;
    int RandomInt4;
    int RandomInt5;
    int RandomInt6;
    int RandomInt7;
    int RandomInt8;
    int RandomInt9;
    int RandomInt10;



    

    public bool is6empty = true;
    public bool is7empty = true;
    public bool is8empty = true;
    public bool is9empty = true;
    public bool is10empty = true;

    bool isBoolDone = false;
    bool isCharDone = false;
    bool isFloatDone = false;
    bool isIntDone = false;
    bool isStringDone = false;

    public bool isReadytoBegin;

    int CardCounter;

    


    void Awake()
    {
        bool_cards = GameObject.FindGameObjectsWithTag("bool_Cards");
        char_cards = GameObject.FindGameObjectsWithTag("char_Cards");
        float_cards = GameObject.FindGameObjectsWithTag("float_Cards");
        int_cards = GameObject.FindGameObjectsWithTag("int_Cards");
        string_cards = GameObject.FindGameObjectsWithTag("string_Cards");

        title_Cards = GameObject.FindGameObjectsWithTag("Cards_title");

        isReadytoBegin = false;

        
    }

    void ReadyStart()
    {
        if(isReadytoBegin)
        {
            for (int positionofArray = 0; positionofArray < bool_cards.Length; positionofArray++)
            {
                GameObject obj = bool_cards[positionofArray];
                int randomArray = Random.Range(0, positionofArray);
                bool_cards[positionofArray] = bool_cards[randomArray];
                bool_cards[randomArray] = obj;
            }
            Spawn_boolCards();

            for (int positionofArray = 0; positionofArray < char_cards.Length; positionofArray++)
            {
                GameObject obj = char_cards[positionofArray];
                int randomArray = Random.Range(0, positionofArray);
                char_cards[positionofArray] = char_cards[randomArray];
                char_cards[randomArray] = obj;
            }
            Spawn_charCards();

            for (int positionofArray = 0; positionofArray < float_cards.Length; positionofArray++)
            {
                GameObject obj = float_cards[positionofArray];
                int randomArray = Random.Range(0, positionofArray);
                float_cards[positionofArray] = float_cards[randomArray];
                float_cards[randomArray] = obj;
            }
            Spawn_floatcards();

            for (int positionofArray = 0; positionofArray < int_cards.Length; positionofArray++)
            {
                GameObject obj = int_cards[positionofArray];
                int randomArray = Random.Range(0, positionofArray);
                int_cards[positionofArray] = int_cards[randomArray];
                int_cards[randomArray] = obj;
            }
            Spawn_intcards();

            for (int positionofArray = 0; positionofArray < string_cards.Length; positionofArray++)
            {
                GameObject obj = string_cards[positionofArray];
                int randomArray = Random.Range(0, positionofArray);
                string_cards[positionofArray] = string_cards[randomArray];
                string_cards[randomArray] = obj;
            }
            Spawn_stringcards();





            for (int positionofArrays = 0; positionofArrays < title_Cards.Length; positionofArrays++)
            {
                GameObject objs = title_Cards[positionofArrays];
                int randomArray = Random.Range(0, positionofArrays);
                title_Cards[positionofArrays] = title_Cards[randomArray];
                title_Cards[randomArray] = objs;
            }
            SpawnTitleCards();

            StartCoroutine(SpawneveryCards());
            isReadytoBegin = false;
        }
        
        

    }

    

    void Spawn_boolCards()
    {        
        RandomInt6 = Random.Range(0, bool_cards.Length);       
        
    }

    void Spawn_charCards()
    {
        RandomInt7 = Random.Range(0, char_cards.Length);
        
    }

    void Spawn_floatcards()
    {
        RandomInt8 = Random.Range(0, float_cards.Length);
        
    }

    void Spawn_intcards()
    {
        RandomInt9 = Random.Range(0, int_cards.Length);
        
    }

    void Spawn_stringcards()
    {
        RandomInt10 = Random.Range(0, string_cards.Length);
        
        
    }

    public void isReadyTobegin_true()
    {
        isReadytoBegin = true;
    }

    public bool GetisReadytoBegin()
    {
        return isReadytoBegin;
    }

    IEnumerator SpawneveryCards()
    {
        while(is6empty || is7empty || is8empty || is9empty || is10empty)
        {
            if (isBoolDone && isCharDone && isFloatDone && isIntDone && isStringDone)
            {
                break;
            }

            int ran_boolcards = Random.Range(6, 11);
            int ran_charcards = Random.Range(6, 11);
            int ran_floatlcards = Random.Range(6, 11);
            int ran_intcards = Random.Range(6, 11);
            int ran_stringcards = Random.Range(6, 11);
            if (!isBoolDone)
            {
                if (ran_boolcards == 6)
                {
                    if (is6empty)
                    {
                        RandomInt6 = Random.Range(0, bool_cards.Length);
                        Instantiate(bool_cards[RandomInt6], Card6_Pos.position, Card6_Pos.rotation);
                        is6empty = false;
                        isBoolDone = true;
                        
                    }
                }
                else if (ran_boolcards == 7)
                {
                    if (is7empty)
                    {
                        RandomInt6 = Random.Range(0, bool_cards.Length);
                        Instantiate(bool_cards[RandomInt6], Card7_Pos.position, Card7_Pos.rotation);
                        is7empty = false;
                        isBoolDone = true;
                        
                    }
                }
                else if (ran_boolcards == 8)
                {
                    if (is8empty)
                    {
                        RandomInt6 = Random.Range(0, bool_cards.Length);
                        Instantiate(bool_cards[RandomInt6], Card8_Pos.position, Card8_Pos.rotation);
                        is8empty = false;
                        isBoolDone = true;
                       
                    }
                }
                else if (ran_boolcards == 9)
                {
                    if (is9empty)
                    {
                        RandomInt6 = Random.Range(0, bool_cards.Length);
                        Instantiate(bool_cards[RandomInt6], Card9_Pos.position, Card9_Pos.rotation);
                        is9empty = false;
                        isBoolDone = true;
                        
                    }
                }
                else if (ran_boolcards == 10)
                {
                    if (is10empty)
                    {
                        RandomInt6 = Random.Range(0, bool_cards.Length);
                        Instantiate(bool_cards[RandomInt6], Card10_Pos.position, Card10_Pos.rotation);
                        is10empty = false;
                        isBoolDone = true;
                        
                    }
                }
            }
            if (!isCharDone)
            {
                if (ran_charcards == 6)
                {
                    if (is6empty)
                    {
                        RandomInt7 = Random.Range(0, char_cards.Length);
                        Instantiate(char_cards[RandomInt7], Card6_Pos.position, Card6_Pos.rotation);
                        is6empty = false;
                        isCharDone = true;
                        
                    }
                }
                else if (ran_charcards == 7)
                {
                    if (is7empty)
                    {
                        RandomInt7 = Random.Range(0, char_cards.Length);
                        Instantiate(char_cards[RandomInt7], Card7_Pos.position, Card7_Pos.rotation);
                        is7empty = false;
                        isCharDone = true;
                        
                    }
                }
                else if (ran_charcards == 8)
                {
                    if (is8empty)
                    {
                        RandomInt7 = Random.Range(0, char_cards.Length);
                        Instantiate(char_cards[RandomInt7], Card8_Pos.position, Card8_Pos.rotation);
                        is8empty = false;
                        isCharDone = true;
                        
                    }
                }
                else if (ran_charcards == 9)
                {
                    if (is9empty)
                    {
                        RandomInt7 = Random.Range(0, char_cards.Length);
                        Instantiate(char_cards[RandomInt7], Card9_Pos.position, Card9_Pos.rotation);
                        is9empty = false;
                        isCharDone = true;
                        
                    }
                }
                else if (ran_charcards == 10)
                {
                    if (is10empty)
                    {
                        RandomInt7 = Random.Range(0, char_cards.Length);
                        Instantiate(char_cards[RandomInt7], Card10_Pos.position, Card10_Pos.rotation);
                        is10empty = false;
                        isCharDone = true;
                        
                    }
                }
            }
            if (!isFloatDone)
            {
                if (ran_floatlcards == 6)
                {
                    if (is6empty)
                    {
                        RandomInt8 = Random.Range(0, float_cards.Length);
                        Instantiate(float_cards[RandomInt8], Card6_Pos.position, Card6_Pos.rotation);
                        is6empty = false;
                        isFloatDone = true;
                        
                    }
                }
                else if (ran_floatlcards == 7)
                {
                    if (is7empty)
                    {
                        RandomInt8 = Random.Range(0, float_cards.Length);
                        Instantiate(float_cards[RandomInt8], Card7_Pos.position, Card7_Pos.rotation);
                        is7empty = false;
                        isFloatDone = true;
                        
                    }
                }
                else if (ran_floatlcards == 8)
                {
                    if (is8empty)
                    {
                        RandomInt8 = Random.Range(0, float_cards.Length);
                        Instantiate(float_cards[RandomInt8], Card8_Pos.position, Card8_Pos.rotation);
                        is8empty = false;
                        isFloatDone = true;
                        
                    }
                }
                else if (ran_floatlcards == 9)
                {
                    if (is9empty)
                    {
                        RandomInt8 = Random.Range(0, float_cards.Length);
                        Instantiate(float_cards[RandomInt8], Card9_Pos.position, Card9_Pos.rotation);
                        is9empty = false;
                        isFloatDone = true;
                        
                    }
                }
                else if (ran_floatlcards == 10)
                {
                    if (is10empty)
                    {
                        RandomInt8 = Random.Range(0, float_cards.Length);
                        Instantiate(float_cards[RandomInt8], Card10_Pos.position, Card10_Pos.rotation);
                        is10empty = false;
                        isFloatDone = true;
                        
                    }
                }
            }
            if (!isIntDone)
            {
                if (ran_intcards == 6)
                {
                    if (is6empty)
                    {
                        RandomInt9 = Random.Range(0, int_cards.Length);
                        Instantiate(int_cards[RandomInt9], Card6_Pos.position, Card6_Pos.rotation);
                        is6empty = false;
                        isIntDone = true;
                        
                    }
                }
                else if (ran_intcards == 7)
                {
                    if (is7empty)
                    {
                        RandomInt9 = Random.Range(0, int_cards.Length);
                        Instantiate(int_cards[RandomInt9], Card7_Pos.position, Card7_Pos.rotation);
                        is7empty = false;
                        isIntDone = true;
                        
                    }
                }
                else if (ran_intcards == 8)
                {
                    if (is8empty)
                    {
                        RandomInt9 = Random.Range(0, int_cards.Length);
                        Instantiate(int_cards[RandomInt9], Card8_Pos.position, Card8_Pos.rotation);
                        is8empty = false;
                        isIntDone = true;
                        
                    }
                }
                else if (ran_intcards == 9)
                {
                    if (is9empty)
                    {
                        RandomInt9 = Random.Range(0, int_cards.Length);
                        Instantiate(int_cards[RandomInt9], Card9_Pos.position, Card9_Pos.rotation);
                        is9empty = false;
                        isIntDone = true;
                        
                    }
                }
                else if (ran_intcards == 10)
                {
                    if (is10empty)
                    {
                        RandomInt9 = Random.Range(0, int_cards.Length);
                        Instantiate(int_cards[RandomInt9], Card10_Pos.position, Card10_Pos.rotation);
                        is10empty = false;
                        isIntDone = true;
                        
                    }
                }
            }
            if (!isStringDone)
            {
                if (ran_stringcards == 6)
                {
                    if (is6empty)
                    {
                        RandomInt10 = Random.Range(0, string_cards.Length);
                        Instantiate(string_cards[RandomInt10], Card6_Pos.position, Card6_Pos.rotation);
                        is6empty = false;
                        isStringDone = true;
                        
                    }
                }
                else if (ran_stringcards == 7)
                {
                    if (is7empty)
                    {
                        RandomInt10 = Random.Range(0, string_cards.Length);
                        Instantiate(string_cards[RandomInt10], Card7_Pos.position, Card7_Pos.rotation);
                        is7empty = false;
                        isStringDone = true;
                        
                    }
                }
                else if (ran_stringcards == 8)
                {
                    if (is8empty)
                    {
                        RandomInt10 = Random.Range(0, string_cards.Length);
                        Instantiate(string_cards[RandomInt10], Card8_Pos.position, Card8_Pos.rotation);
                        is8empty = false;
                        isStringDone = true;
                        
                    }
                }
                else if (ran_stringcards == 9)
                {
                    if (is9empty)
                    {
                        RandomInt10 = Random.Range(0, string_cards.Length);
                        Instantiate(string_cards[RandomInt10], Card9_Pos.position, Card9_Pos.rotation);
                        is9empty = false;
                        isStringDone = true;
                        
                    }
                }
                else if (ran_stringcards == 10)
                {
                    if (is10empty)
                    {
                        RandomInt10 = Random.Range(0, string_cards.Length);
                        Instantiate(string_cards[RandomInt10], Card10_Pos.position, Card10_Pos.rotation);
                        is10empty = false;
                        isStringDone = true;
                        
                    }
                }
            }

            yield return new WaitForSeconds(0.001f);
        }
    }






    void SpawnTitleCards()
    {

        RandomInt1 = 0;
        RandomInt2 = 1;
        RandomInt3 = 2;
        RandomInt4 = 3;
        RandomInt5 = 4;


        Instantiate(title_Cards[RandomInt1], Card1_Pos.position, Card1_Pos.rotation);
        Instantiate(title_Cards[RandomInt2], Card2_Pos.position, Card2_Pos.rotation);
        Instantiate(title_Cards[RandomInt3], Card3_Pos.position, Card3_Pos.rotation);
        Instantiate(title_Cards[RandomInt4], Card4_Pos.position, Card4_Pos.rotation);
        Instantiate(title_Cards[RandomInt5], Card5_Pos.position, Card5_Pos.rotation);

    }

    public bool GetisCardSelected()
    {
        return isCardSelected;
    }

    public void isCardSelected_True()
    {
        isCardSelected = true;
    }

    public void isCardSelected_False()
    {
        isCardSelected = false;
    }

    public bool GetDeleteBoolCard()
    {
        return DeleteBoolCard;
    }

    public bool GetDeleteCharCard()
    {
        return DeleteCharCard;
    }

    public bool GetDeleteFloatCard()
    {
        return DeleteFloatCard;
    }

    public bool GetDeleteIntCard()
    {
        return DeleteIntCard;
    }

    public bool GetDeleteStringCard()
    {
        return DeleteStringCard;
    }

    public void DeleteBoolCard_True()
    {
        DeleteBoolCard = true;
    }

    public void DeleteBoolCard_False()
    {
        DeleteBoolCard = false;
    }

    public void DeleteCharCard_True()
    {
        DeleteCharCard = true;
    }

    public void DeleteCharCard_False()
    {
        DeleteCharCard = false;
    }

    public void DeleteFloatCard_True()
    {
        DeleteFloatCard = true;
    }

    public void DeleteFloatCard_False()
    {
        DeleteFloatCard = false;
    }

    public void DeleteIntCard_True()
    {
        DeleteIntCard = true;
    }

    public void DeleteIntCard_False()
    {
        DeleteIntCard = false;
    }

    public void DeleteStringCard_True()
    {
        DeleteStringCard = true;
    }

    public void DeleteStringCard_False()
    {
        DeleteStringCard = false;
    }
    
    public bool GetBool_title()
    {
        return BooltitleSelected;
    }

    public void GetBooltitle_true()
    {
        BooltitleSelected = true;
    }

    public void GetBooltitle_false()
    {
        BooltitleSelected = false;
    }

    public bool GetChar_title()
    {
        return ChartitleSelected;
    }

    public void GetChartitle_true()
    {
        ChartitleSelected = true;
    }

    public void GetChartitle_false()
    {
        ChartitleSelected = false;
    }

    public bool GetFloat_title()
    {
        return FloattitleSelected;
    }

    public void GetFloattitle_true()
    {
        FloattitleSelected = true;
    }

    public void GetFloattitle_false()
    {
        FloattitleSelected = false;
    }

    public bool GetInt_title()
    {
        return InttitleSelected;
    }

    public void GetInttitle_true()
    {
        InttitleSelected = true;
    }

    public void GetInttitle_false()
    {
        InttitleSelected = false;
    }

    public bool GetString_title()
    {
        return StringtitleSelected;
    }

    public void GetStringtitle_true()
    {
        StringtitleSelected = true;
    }

    public void GetStrirngtitle_false()
    {
        StringtitleSelected = false;
    }

    public bool GetBool()
    {
        return BoolSelected;
    }

    public void GetBool_true()
    {
        BoolSelected = true;
    }

    public void GetBool_false()
    {
        BoolSelected = false;
    }

    public bool GetChar()
    {
        return CharSelected;
    }

    public void GetChar_true()
    {
        CharSelected = true;
    }

    public void GetChar_false()
    {
        CharSelected = false;
    }

    public bool GetFloat()
    {
        return FloatSelected;
    }

    public void GetFloat_true()
    {
        FloatSelected = true;
    }

    public void GetFloat_false()
    {
        FloatSelected = false;
    }

    public bool GetInt()
    {
        return IntSelected;
    }

    public void GetInt_true()
    {
        IntSelected = true;
    } 

    public void GetInt_false()
    {
        IntSelected = false;
    }

    public bool GetString()
    {
        return StringSelected;
    }

    public void GetString_true()
    {
        StringSelected = true;
    }

    public void GetString_false()
    {
        StringSelected = false;
    }

    public void ResetAllBool()
    {
        BooltitleSelected = false;
        ChartitleSelected = false;
        FloattitleSelected = false;
        InttitleSelected = false;
        StringtitleSelected = false;

        BoolSelected = false;
        CharSelected = false;
        FloatSelected = false;
        IntSelected = false;
        StringSelected = false;
    }



    void Update()
    {
        if(!is6empty && !is7empty && !is8empty && !is9empty && !is10empty)
        {
            StopCoroutine(SpawneveryCards());
        }

        if(isReadytoBegin)
        {
            ReadyStart();
        }

        title_Cards = GameObject.FindGameObjectsWithTag("Cards_title");

        CardCounter = title_Cards.Length;

        

        if(CardCounter == 0)
        {
            SceneManager.LoadScene("SuccessScene");
        }
    }

    public void RestartGame()
    {
        isReadytoBegin = true;
        PuasePanel.SetActive(false);
    }



}
