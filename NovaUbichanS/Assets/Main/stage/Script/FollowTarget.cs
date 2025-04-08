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

using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target; // The object the camera should follow
    public Vector3 offset;    // Offset from the target's position
    public float smoothSpeed = 0.125f; // Smoothing speed
    [HideInInspector] public bool IsArrive;
    private Vector3 velocity = Vector3.zero; // Used for smooth dampening

    public void RunFollowSmooth()
    {
        //Check target is exist.
        if (target == null) return; 

        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothSpeed);

        if (Vector3.Distance(desiredPosition, transform.position) < 0.001f) 
        { transform.position = desiredPosition; IsArrive = true; }
        else {  IsArrive = false; }
    }
}