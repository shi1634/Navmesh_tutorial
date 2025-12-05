using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem; 

public class Playercontrol : MonoBehaviour
{
    public NavMeshAgent myAgent;

    void Update()
    {
       
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            
            Vector2 mousePos = Mouse.current.position.ReadValue();
            
       
            Ray point= Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hitInfo;

            if (Physics.Raycast(point, out hitInfo))
            {
                myAgent.SetDestination(hitInfo.point);
            }
        }
    }
}