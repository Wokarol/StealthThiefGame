﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wokarol
{
    public class PlayerInput : InputData
    {
        private Vector2 movement = default;
        private bool hide = default;

        public override Vector2 Movement => movement;
        public override bool Hide => hide;

        void Update() {
            movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            hide = Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0) || Input.GetKey(KeyCode.JoystickButton1); ;
        }
    } 
}
