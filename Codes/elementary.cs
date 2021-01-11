using System;
public class VariablesAndFunctions : MonoBehavior{
    int myInt = 5;

    void Start(){ //Start is called when the object is attached to enters a scene
        myInt = 10;

        multiplyByTwo(myInt);

        Debug.log(myInt);
    }

    int multiplyByTwo(int num){
        int ret;
        ret = number * 2;
        
        return ret;
    }
}

