using System;
public class ForeachLoop : MonoBehavior{
    void Start(){
        string[] strings = new string[3];
        
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach(string item in strings){
            print (item);
        }
    }
}