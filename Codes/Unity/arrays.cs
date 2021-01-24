using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour{
    int[] myIntArray = new int[5];
    int[] myIntArray = {12, 76, 8, 937, 903};

    void Start(){
        myIntArray[0] = 12;
    }
}


public class Arrays : MonoBehaviour{
    GameObject[] Players;

    void Start(){
        players = GameObject.FindGameObjectsWithTag("Player");
    }
}