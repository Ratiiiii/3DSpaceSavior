using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float turnSpeed = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null)
        {           
            Destroy(gameObject);
            return;
        }

        //checkplayer
        if(other.gameObject.name != "Player")
        {
            return;
        }
        //score
        GameManager.inst.IncrementScore();

        //destroy
        Destroy(gameObject);
        AudioManager.instance.audiocoin();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, turnSpeed * Time.deltaTime);
    }
}
