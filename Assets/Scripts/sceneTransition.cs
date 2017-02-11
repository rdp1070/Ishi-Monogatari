using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class sceneTransition : MonoBehaviour {

    public string Destination;
 
    public void LoadScene()
    {
        SceneManager.LoadScene(Destination);
    }

}
