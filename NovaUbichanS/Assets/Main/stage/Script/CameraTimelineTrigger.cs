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
using UnityEngine.Playables;

namespace Ubitus.UbiChanVTuber.TheatreDirector
{
    [RequireComponent(typeof(PlayableDirector))]
    public class CameraTimelineTrigger : MonoBehaviour
    {
        public KeyCode StartKey;
        public KeyCode StopKey;
        private PlayableDirector _playableDirector;

        void Start()
        {
            _playableDirector = GetComponent<PlayableDirector>();
        }

        public void PlayTimeline()
        { _playableDirector.Play(); }

        public void StopTimeline()
        { _playableDirector.Stop(); }

    }
}
