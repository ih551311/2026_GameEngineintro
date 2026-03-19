using UnityEngine;

public class test : MonoBehaviour
{
    float BasicMath(float a, float b, short sel) // 1=(a+b), 2=(a-b), 3=(a*b), 4=(a/b)
    {
        if (sel == 1) 
            return a + b;
        if (sel == 2) 
            return a - b;
        if (sel == 3) 
            return a * b;
        if (sel == 4) 
            return a / b;
        else
            return 0;
    }
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
