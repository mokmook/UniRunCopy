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
             num % 2 == 0 ? Debug.Log("0���� ū ¦��") : Debug.Log("0���� ū Ȧ��")
        }

     string a =  num >= 90 ? value="A" : num >= 80 ?value="B" : num >= 70 ?value="C" : value="F";

        Debug.Log(a);*/
        if (num > 100 || num < 0||age<1)
        {
            Debug.Log("��� ����");
            return;
        }
        if (age == 4)
        {
            if (num >= 70)
                print("�հ�");
            else
                print("���հ�");

        }
        else
        {
            if (num>=60)
                print("�հ�");
            else
                print("���հ�");


        }
        string a=  num > 100 || num < 0 ? value = "��� ����" : age == 4 && num >= 70 ? value = "�հ�" : value = "���հ�";
        string b = num > 100 || num < 0 ? value = "��� ����" : age != 4 && num >= 60 ? value = "�հ�" : value = "���հ�";

        if (age == 4)
            Debug.Log(a);
        else
            Debug.Log(b);
    }

    void Update()
    {
        
    }
}
