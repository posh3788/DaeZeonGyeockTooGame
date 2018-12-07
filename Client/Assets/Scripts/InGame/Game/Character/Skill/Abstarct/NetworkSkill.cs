﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class NetworkSkill {
    public Vector2 CastDirection;
    public Vector2 CastPosition;
    public long NetworkId;

    public long SkillId;
}