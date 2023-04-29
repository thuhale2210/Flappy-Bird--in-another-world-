using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{  
    public void LoadGame(int index) {
        SceneManager.LoadScene(index);
    }
}
