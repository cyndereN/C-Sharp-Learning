using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{
    void Start(){

    }

    void Update(){
        if(Input.GetKeyUp(KeyCode.Escape)){
            SceneManager.LoadScene(1);
        }
    }
}