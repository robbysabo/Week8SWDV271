using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        exercise1();
        exercise2();
        exercise3();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void exercise1()
    {
        int minNum = 2;
        int maxNum = 499;
        int totalNum = 0;

        for (int i = minNum; i < maxNum; i++)
        {
            if (i % 2 == 0)
                totalNum += i;
        }

        print("1.The sum of the even numbers between 2 and 499 is?\nExerecise 1 Anwser: " + totalNum.ToString());
    }

    void exercise2()
    {
        int startNum = 1;
        int endNum = 100;
        int avoid1 = 3;
        int avoid2 = 5;

        for (int i = startNum; i < endNum; i++)
        {
            bool isMultipleofAvoid1 = i % avoid1 == 0;
            bool isMultipleofAvoid2 = i % avoid2 == 0;

            if (isMultipleofAvoid1 ||  isMultipleofAvoid2)
            {
                print("Programming is Awesome!");
            } else
            {
                print(i.ToString());
            }
        }
    }

    void exercise3()
    {
        int fibLength = 20;
        int resultNumA = 1;
        int resultNumB = 1;

        print("3.Fibonacci sequence:");

        for (int i = 0; i < fibLength; i++)
        {
            int result = resultNumA + resultNumB;
            print((i + 1).ToString() + ". " + result.ToString());

            resultNumA = resultNumB;
            resultNumB = result;
        }
    }
}
