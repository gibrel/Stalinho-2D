using Stalinho2D.Combat;
using Stalinho2D.UI;
using UnityEngine;

namespace Stalinho2D.Skills
{
    public class ShootController : MonoBehaviour
    {
        [SerializeField] private FirearmController[] firearms;

        void Update()
        {
            Shoot();
        }

        private void Shoot()
        {
            if (PauseMenu.GameIsPaused) return;

            foreach (FirearmController gun in firearms)
            {
                if (gun.IsPlayer)
                {
                    if (Input.GetMouseButton(gun.FirearmGroup))
                    {
                        gun.Shoot();
                    }
                }
                else
                {
                    gun.Shoot();
                }
            }
        }
    }

}