using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AM {

public class DataHolder : MonoBehaviour {
public static DataHolder Instance;

    public int tileNumber  = 1;

        public int activeNumber  = 0;
 
  private void Awake() {
   if (Instance != null) {
     Destroy(gameObject);
   }else{
     Instance = this;
   }
 }
}

}
