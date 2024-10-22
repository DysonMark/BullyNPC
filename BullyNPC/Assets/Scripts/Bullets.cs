using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullets : MonoBehaviour
{
   public AudioSource hitSource;
   public float life = 3;
   
   /*
   void Awake()
   {
      Destroy(gameObject, life);
   }*/

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.R))
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   public void OnCollisionEnter(Collision collision)
   {
      if (collision.gameObject.tag == "Player")
      {
         Debug.Log("hit");
         hitSource.Play();
      }
      Destroy(gameObject);
   }
}
