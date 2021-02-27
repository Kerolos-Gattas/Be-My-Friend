using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public void LookAtCharacter(Transform character, CharacterController2D controller)
    {
        float horizPos = transform.position.x;
        float characterHorizPos = character.position.x;
        if ((characterHorizPos < horizPos && controller.getFacingRight()) || (characterHorizPos > horizPos && !controller.getFacingRight()))
        {
            controller.Flip();
        }
    }
}
