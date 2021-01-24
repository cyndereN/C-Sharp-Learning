using UnityEngine;
using System.Collections;

public class ConversationScript : MonoBehaviour{
    public int intelligence = 5;

    void Greet(){
        switch(intelligence){
            case 5:
                print("Hello there good sir! Let me teach you about Trigonometry!");
                break;

            case 4:
                print("Hello and good day!");
                break;
                
            default:
                print("Incorrect intelligence level.");
                break;
        }
    }
}