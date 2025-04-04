using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonstuff: MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelChange(string level)
    {
        SceneManager.LoadScene(level);
        PlayerPrefs.DeleteKey("LIVES_LEFT");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
