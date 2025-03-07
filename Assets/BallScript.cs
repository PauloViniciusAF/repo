using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb2d;  
    public AudioSource source;
    // Start is called once before the first execution of Update after the MonoBehaviour is created// inicializa a bola randomicamente para esquerda ou direita
    void GoBall(){                      
        float rand = Random.Range(0, 2);
        if(rand < 1){
            rb2d.AddForce(new Vector2(20, -15));
        } else {
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }
    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == "Brick"){
            Destroy(coll.gameObject); 
            source.Play(); 
        }
        if (coll.gameObject.tag == "BrickPowerUp"){
            Destroy(coll.gameObject); 
            source.Play(); 
            
        }
        if (coll.gameObject.tag == "Bottom"){
            RestartGame();  
        }
}

    void Start () {
        rb2d = GetComponent<Rigidbody2D>(); // Inicializa o objeto bola
        Invoke("GoBall", 2);    // Chama a função GoBall após 2 segundos
        source = GetComponent<AudioSource>();
    }
        // Determina o comportamento da bola nas colisões com os Players (raquetes)

        // Reinicializa a posição e velocidade da bola
    void ResetBall(){
        rb2d.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    // Reinicializa o jogo
    void RestartGame(){
        ResetBall();
        Invoke("GoBall", 1);
    }
}
