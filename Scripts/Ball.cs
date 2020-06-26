using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D _rigidbody2D;
    public float dircetion;
    [SerializeField]
    private UIManager _uIManager;
    [SerializeField]
    private Transform[] _padle;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _uIManager =GameObject.Find("Canvas").GetComponent<UIManager>();
        Direction();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Direction()
    {
        dircetion = Random.Range(0, 2);
        if (dircetion==0)
        {
            _rigidbody2D.velocity = new Vector2(5f, -3f);
           //Direction();
        }
        else
        {
            _rigidbody2D.velocity = new Vector2(-5f, 3f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag== "WallGreen")
        {
            _uIManager.PointRed++;
            _uIManager.ScoreTable();
        }
        else
        {
            _uIManager.PointGreen++;
            _uIManager.ScoreTable();
        }
    }
    public void RetutnPositionBall()
    {
        _uIManager._continousText = false;
        transform.position = new Vector2(0, 0);
        _rigidbody2D.velocity = new Vector2(0, 0);
        _padle[0].transform.position = new Vector2(-6.20f, 0f);
        _padle[1].transform.position = new Vector2(6.20f, 0f);
        Direction();
    }
}
