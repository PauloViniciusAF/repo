using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int lives = 3; // Pontuação do player 1
    public static int score = 0; // Pontuação do player 2
    // public Text liveText;
    // public Text scoreText;
    // public bool gameOver;
    public GameObject gameOverPanel;

    public GUISkin layout;              // Fonte do placar
    GameObject theBall;                 // Referência ao objeto bola

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start () {
        theBall = GameObject.FindGameObjectWithTag("Ball"); // Busca a referência da bola
        // liveText.text = "Vidas: " + lives;
        // scoreText.text = "Score " + score;
    }
    public static void live (string wallID) {
        if (wallID == "wall_bottom")
        {
            lives--;
        } 
    }
    void OnGUI () {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + lives);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + score);
        if (lives == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER ONE WINS");
        } else if (score == 10)
        {
            GUI.Label(new Rect(Screen.width / 2 - 150, 200, 2000, 1000), "PLAYER TWO WINS");
        }
}
}
