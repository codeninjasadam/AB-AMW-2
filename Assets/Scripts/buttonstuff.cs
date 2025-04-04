using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
        PlayerPrefs.DeleteKey("LIVES_LEFT");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
