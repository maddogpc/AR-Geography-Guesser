using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public static Score instance;
    public Text scoreText;

    int score = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " Points";
    }

   public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " Points ";
        Debug.Log(SceneManager.GetActiveScene());
    }
}
