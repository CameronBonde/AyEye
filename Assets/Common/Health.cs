using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public int amount;
    int max = 100;

    public UnityEvent OnDied;
    
    public void ChangeHealth(int _amount)
    {
        amount += _amount;
        if (amount<=0)
        {
            OnDied.Invoke();
        }
    }
}
