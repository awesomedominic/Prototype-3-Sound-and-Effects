using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 30;
    private PlayerController _playerControllerScript;
    private float _leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Will Stop Moving B.G. and Obstacles left if GameOver = true
        if (_playerControllerScript.GameOver == false)
        transform.Translate(Vector3.left * Time.deltaTime * Speed);

        // Destroy Obstacles after exiting Boundaries
        if (transform.position.x < _leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
