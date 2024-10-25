using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public List<string> levels;
    int _currentLevel = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MainGame.Instance.Player.GetHasFinishedLevel())
        {
            SceneManager.LoadScene(levels[_currentLevel]);
            _currentLevel++;
        }
    }
}
