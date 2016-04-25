using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;	

	//private GameObject _GM;
	private Rigidbody2D _r;
    private PlayerController _PC;
	private Vector3 _moveVector;
	private string _x;
	private string _y;


    void Awake()
    {
        //_GM = GameObject.FindGameObjectWithTag("GameController");
        _PC = GetComponent<PlayerController>();
        _r = GetComponent<Rigidbody2D>();
    }


	void Start () {
		if (name == "P1") {
			_x = "LeftStickX1";
			_y = "LeftStickY1";
		}else { //P2 
			_x = "LeftStickX2";
			_y = "LeftStickY2";
		}
	}
	
	
	void FixedUpdate () {
		if (!_PC.isAttacking () )
        {
			_moveVector.x = Input.GetAxis (_x);
			_moveVector.y = Input.GetAxis (_y) * -1;
			_moveVector.z = 0f;

			_r.velocity = _moveVector * speed;
		}
	}
}
