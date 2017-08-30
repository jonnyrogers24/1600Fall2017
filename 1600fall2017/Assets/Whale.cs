using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : Mammal {

    public override void Start() {
        base.Start(); 
        EchoLocate();
    }

    void EchoLocate () {
        print(this.name + " Echo Locates");
    }
}
