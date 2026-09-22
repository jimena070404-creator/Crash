using UnityEngine;
using UnityEngine.Events;

public class RollControler : MonoBehaviour
{
   [SerializeField]
   private InputController inputController;
   [SerializeField]
   private UnityEvent onRoll;
   private void Update()
    {
        if (inputController.Roll)
        {
            Roll();
        }
    }
    private void Roll()
    {
        onRoll?.Invoke();   
    }
}
