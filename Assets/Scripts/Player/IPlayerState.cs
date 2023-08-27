using UnityEngine;

namespace Assets.Scripts.Player
{
    public interface IPlayerState
    {
        void HandleInput();
        void Update();
    }
}