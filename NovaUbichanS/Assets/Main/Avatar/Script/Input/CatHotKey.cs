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

namespace Ubitus.UbiChanVTuber.Avatar
{
    public class CatHotKey : MonoBehaviour
    {
        public Animator CatAnimator;
        private void Update()
        {
            HotKey();
        }
        public void HotKey()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                CatAnimator.SetTrigger("cat_idle");
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                CatAnimator.SetTrigger("cat_backflip");
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                CatAnimator.SetTrigger("cat_dance");
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                CatAnimator.SetTrigger("cat_play");
            }
        }
    }
}
