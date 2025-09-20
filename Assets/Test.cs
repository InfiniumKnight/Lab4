using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    class Damage
    {
        static void Damaged(string[] args)
        {
            DamageProcessor<int> dp = new DamageProcessor<int>();
            dp.Process("TEST");
            dp.Process<float>(3.5f);
        }
    }

    class DamageProcessor<T>
    {
        public void Process<T>(T value)
        {
            Debug.Log(value.GetType().Name + " ");
        }
    }
}
