using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpike : MonoBehaviour
{
    public Text die;
    public Text preg;
    public Text verd;
    public Text fals;
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.CompareTag("Player")){
            Debug.Log("Player Damage");
            collision.transform.GetComponent<PlayerRespaw>().PlayerDamaged();
            if (preg != null && verd != null && fals != null ) {
                preg.gameObject.SetActive(false);
            }
            
            die.gameObject.SetActive(true);
        }
    }
}
