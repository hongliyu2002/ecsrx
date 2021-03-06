﻿using System;
using System.Collections.Generic;
using EcsRx.Entities;

namespace EcsRx.Groups
{
    public class Group : IGroup
    {
        public IEnumerable<Type> TargettedComponents { get; private set; }
        public Predicate<IEntity> TargettedEntities { get; private set; }

        public Group(params Type[] targettedComponents)
        {
            TargettedComponents = targettedComponents;
            TargettedEntities = null;
        }

        public Group(Predicate<IEntity> targettedEntities, params Type[] targettedComponents)
        {
            TargettedComponents = targettedComponents;
            TargettedEntities = targettedEntities;
        }
    }
}