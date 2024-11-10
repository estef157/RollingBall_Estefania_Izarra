using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] GameObject pausa;
     // Start is called before the first frame update
    void Start()
    {
        pausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausa.SetActive (true);
            Time.timeScale = 0;
        }
        else if(Input.GetKeyUp(KeyCode.Escape))
        {
            pausa.SetActive(false);
        }
    }


    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
