
using UnityEngine;

using RTSEngine.Entities;

namespace RTSEngine.Attack
{
    public struct LaunchAttackData<T>
    {
        public T source;

        public IFactionEntity targetEntity;

        public Vector3 targetPosition;

        public bool playerCommand;

        public bool allowTerrainAttack;
    }
}