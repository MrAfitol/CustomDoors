using Mirror;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CustomDoors
{
    public class EventHandlers
    {
        private List<GameObject> spawnedDoors = new List<GameObject>();

        internal void OnRoundStarted()
        {
            SpawnDoor();
        }

        byte doorType = 0;
        internal void SpawnDoor(Vector3 position, Vector3 rotation, Vector3 scale)
        {
            MapGeneration.DoorSpawnpoint prefab = null;

            switch (doorType)
            {
                case 0: prefab = Object.FindObjectsOfType<MapGeneration.DoorSpawnpoint>().First(x => x.TargetPrefab.name.Contains("LCZ")); break;
                case 1: prefab = Object.FindObjectsOfType<MapGeneration.DoorSpawnpoint>().First(x => x.TargetPrefab.name.Contains("HCZ")); break;
                case 2: prefab = Object.FindObjectsOfType<MapGeneration.DoorSpawnpoint>().First(x => x.TargetPrefab.name.Contains("EZ")); break;
            }

            var door = Object.Instantiate(prefab.TargetPrefab, position, Quaternion.Euler(rotation));

            
            door.transform.localScale = scale;


            spawnedDoors.Add(door.gameObject);
            NetworkServer.Spawn(door.gameObject);
        }

        internal void SpawnDoor()
        {
            if (Plugin.Instance.Config.IsEnabledDoor1)
            {
                doorType = 2;
                SpawnDoor(new Vector3(14.4323368f, 995.299988f, -43.4600067f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1.5f));
            }

            if (Plugin.Instance.Config.IsEnabledDoor2)
            {
                doorType = 2;
                SpawnDoor(new Vector3(14.4662657f, 995.299988f, -23.2893047f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1.5f));
            }

            if (Plugin.Instance.Config.IsEnabledDoor3)
            {
                doorType = 2;
                SpawnDoor(new Vector3(174.350174f, 983.373291f, 29.0178833f), new Vector3(0f, 90f, 0f), new Vector3(1f, 1f, 1f));
            }

            if (Plugin.Instance.Config.IsEnabledDoor4)
            {
                doorType = 2;
                SpawnDoor(new Vector3(176.23f, 983.373291f, 35.1f), new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f));
            }
        }
    }
}
