using UnityEngine;

namespace Michael
{
    public class UIMiniHealthBar : MonoBehaviour
    {
        private Entity entity;

        private void Awake()
        {
            entity = GetComponentInParent<Entity>();
        }

        private void OnEnable()
        {
            if (entity != null)
            {
                entity.OnFlipped += FlippedHandle;
            }
        }

        private void OnDisable()
        {
            if (entity != null)
            {
                entity.OnFlipped -= FlippedHandle;
            }
        }

        private void FlippedHandle()
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
