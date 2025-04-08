/*
 * Copyright (C) 2025 Ubitus K.K. (contact@ubitus.net)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ubitus.UbiChanVTuber.Stage
{
    public class RibbonsController : MonoBehaviour
    {
        public KeyCode HotKey;
        public GameObject RibbonsPrefab;
        public Transform SpawnRoot;
        public float DisappearDelay = 10f;
        public Vector3 InitialTorqueRange = new Vector3(10f, 10f, 10f);

        public void Spawn()
        {
            GameObject newGameObject = Instantiate(RibbonsPrefab, SpawnRoot);
            newGameObject.transform.rotation = Quaternion.identity;

            Rigidbody _rigidbody = newGameObject.GetComponent<Rigidbody>();
            if (_rigidbody == null) {_rigidbody = newGameObject.AddComponent<Rigidbody>();}

            SetRotateForce(_rigidbody);
            StartCoroutine(LifeCycle(newGameObject, DisappearDelay));
        }

        private IEnumerator LifeCycle(GameObject newGameObject, float delay)
        {
            yield return new WaitForSeconds(delay);
            Destroy(newGameObject);
        }
        private void SetRotateForce(Rigidbody rigidbody)
        {
            Vector3 randomTorque = new Vector3(
                Random.Range(-InitialTorqueRange.x, InitialTorqueRange.x),
                Random.Range(-InitialTorqueRange.y, InitialTorqueRange.y),
                Random.Range(-InitialTorqueRange.z, InitialTorqueRange.z));
            rigidbody.AddTorque(randomTorque, ForceMode.Impulse); 
        }
    }
}
