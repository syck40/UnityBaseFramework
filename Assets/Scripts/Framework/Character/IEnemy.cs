﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemy : ICharacter {

    void Kill(ICharacter killer);
}
