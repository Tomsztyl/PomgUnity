using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _scoreTableGreen;
    [SerializeField]
    private Text _scoreTableRed;
    [SerializeField]
    private Text _scoreWinner;
    public int PointGreen=0;
    public int PointRed=0;
    [SerializeField]
    private Ball _ball;
    [SerializeField]
    public bool _continousText = false;
    [SerializeField]
    private GameObject _ballObject;
    // Start is called before the first frame update
    void Start()
    {
        _ball = GameObject.Find("Ball").GetComponent<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        ReturnAllGame();
    }
    public void ScoreTable()
    {
        _scoreTableRed.text = ""+PointRed;
        _scoreTableGreen.text = "" + PointGreen;
        if (PointGreen<10&&PointRed<10)
        {
            _ball.RetutnPositionBall();
        }
    }
    private void ReturnAllGame()
    {
        
        if (PointGreen == 10)
        {
            _ballObject.active = false;
            _scoreWinner.text = "Winner is Green!";
            StartCoroutine(TextContinous());
            if (_continousText==true)
            {
                _scoreWinner.text = "Try again press Space";
                RestartGame();
            }
            //ReturnAllGame();
        }
        if (PointRed == 10)
        {
            _ballObject.active = false;
            _scoreWinner.text = "Winner is Red!";
            StartCoroutine(TextContinous());
            if (_continousText == true)
            {
                _scoreWinner.text = "Try again press Space";
                RestartGame();
            }
            //ReturnAllGame();
        }
    }
    private void RestartGame()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PointGreen = 0;
            PointRed = 0;
            _scoreWinner.text = "";
            _scoreTableRed.text = "" + PointRed;
            _scoreTableGreen.text = "" + PointGreen;
            _ballObject.active = true;
            _ball.RetutnPositionBall();
        }
    }
    IEnumerator TextContinous()
    {
        yield return new WaitForSeconds(2);
        _continousText = true;
    }
}
