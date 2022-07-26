using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        int age = 0;
        string userInput = "60";
        int num = int.Parse(userInput);

        string value;
        /*string Num = "10";
        int num=int.Parse(Num);

        if (num>0)
        {
             num % 2 == 0 ? Debug.Log("0보다 큰 짝수") : Debug.Log("0보다 큰 홀수")
        }

     string a =  num >= 90 ? value="A" : num >= 80 ?value="B" : num >= 70 ?value="C" : value="F";

        Debug.Log(a);*/
        if (num > 100 || num < 0||age<1)
        {
            Debug.Log("경고 문구");
            return;
        }
        if (age == 4)
        {
            if (num >= 70)
                print("합격");
            else
                print("불합격");

        }
        else
        {
            if (num>=60)
                print("합격");
            else
                print("불합격");


        }
        string a=  num > 100 || num < 0 ? value = "경고 문구" : age == 4 && num >= 70 ? value = "합격" : value = "불합격";
        string b = num > 100 || num < 0 ? value = "경고 문구" : age != 4 && num >= 60 ? value = "합격" : value = "불합격";

        if (age == 4)
            Debug.Log(a);
        else
            Debug.Log(b);
    }

    void Update()
    {
        
    }
}
