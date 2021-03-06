﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid {
            get { return Validate(); }
        }
        public abstract bool Validate();

        public EntityStateOption EntityState { get; set; }
    }
}
