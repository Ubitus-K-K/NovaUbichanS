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
using System.Globalization;
using Ubitus.UbiChanVTuber.TheatreDirector;
using UnityEngine;

namespace Ubitus.UbiChanVTuber.Stage
{
    public class StageManager : MonoBehaviour
    {
        [Header("Stage Element")]
        public List<RibbonsController> RibbonsList;
        public List<FollowTarget> FollowTargetList;
        public List<CameraTimelineTrigger> TimelineTriggerList;

        void Start()
        {

        }

        void Update()
        {
            HotKeyAction();
            StageCameraAction();
            TimelineAction();
        }
        private void HotKeyAction()
        {
            foreach (var element in RibbonsList)
            {
                if (Input.GetKeyDown(element.HotKey))
                { element.Spawn(); }
            }
        }
        private void StageCameraAction()
        {
            foreach (var element in FollowTargetList)
            {
                if (element.IsArrive is false)
                { element.RunFollowSmooth(); }
            }
        }
        private void TimelineAction()
        {
            foreach (var element in TimelineTriggerList)
            {
                if (Input.GetKeyDown(element.StartKey))
                { element.PlayTimeline(); }

                else if (Input.GetKeyDown(element.StopKey))
                { element.StopTimeline(); }
            }
        }
    }
}
