using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{

    //public Text scoreGT;
    public Text scoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {

        //Find a reference to the ScoreCounter GameObject
        GameObject scoreGO = GameObject.Find("ScoreCounter");

        //Get the GUIText Component of that GameObject
        scoreText = scoreGO.GetComponent<Text>();

        //set starting number of points to 0
        //scoreText.text = "Score: 0";

        //AddScore();
    }

    // Update is called once per frame
    void Update()
    {
        //Get the current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;

        //The camera's z position sets the how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z;

        //Convert the point from 2D screen space into 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //Move the x position of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        //Find what hit the basket
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
        }

        //Parse the text of the scoreGT into an int
        //int score = int.Parse(scoreText.text);
        

        //Add points for catching the apple
        score += 100;

        //Convert the score back to a string and display it
        scoreText.text = "Score: " + score.ToString();

        //Track the High Score
        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
    }

    //void AddScore()
    //{
    //    int score = 0;
    //    scoreText.text = "Score: " + score.ToString();
    //    score += 100;
    //}
}
