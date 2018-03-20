using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fee
{
    public float value;
    public float[] fees;
    public List<Payment> payments = new List<Payment>();

    public void AddMoney(float value)
    {
        for (int i = 0; i < fees.Length; i++)
        {
            if (fees[i] >= value)
                continue;
            else
            {
                if (value > this.value)
                {
                    fees[i] = this.value;
                    value -= this.value;
                }
            }
        }
    }
}
