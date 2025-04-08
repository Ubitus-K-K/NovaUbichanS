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
using Ubitus.UbiChanVTuber.Config;
using UnityEngine;

namespace Ubitus.UbiChanVTuber.Avatar
{
    public class AvatarManager : MonoBehaviour
    {
        public Transform AvatarSpawnRoot;
        public StorageManager StorageManager;
        public AvatarConfig AvatarConfig;
        public AvatarRuntimeStorage RuntimeStorage;

        public void Start()
        {
            RuntimeStorage = new();
            CreateAvatar(AvatarConfig);
        }
        public void CreateAvatar(AvatarConfig avatarConfig)
        {
            AvatarBodyType modelType = avatarConfig.AvatarBody.AvatarBodyType;
            GameObject modelPrefab = StorageManager.AvatarBodyDic[modelType].Model;
            RuntimeStorage.RuntimeAvatar = Instantiate(modelPrefab, AvatarSpawnRoot);

            Vector3 spawnPosition = Vector3.zero;
            Quaternion spawnRotation = Quaternion.identity;
            RuntimeStorage.RuntimeAvatar.transform.localPosition = spawnPosition;
            RuntimeStorage.RuntimeAvatar.transform.rotation = spawnRotation;
        }
        public void SwitchAvatar(AvatarConfig avatarConfig)
        {
            SwitchAvatarBody(avatarConfig.AvatarBody);
        }
        //public AvatarAttribute GetAttribute()
        public void SwitchAvatarBody(AvatarBody avatarBody)
        {
            switch (avatarBody.AvatarBodyType)
            {
                case AvatarBodyType.Normal:break;
                case AvatarBodyType.Anniversary:break;
            }
        }
    }
}
