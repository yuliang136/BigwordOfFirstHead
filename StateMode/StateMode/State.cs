//=========================================================================
// File: State.cs
//
// Summary:
//
// Author: YL
// 
// Created Date:   2016-02-28
//
//=========================================================================
// This file is part of StateMode
//
//
// CopyRight (c)
// 
//
//
//=========================================================================

using System;
using System.Collections.Generic;

namespace StateMode
{
    public abstract class State
    {
        public abstract void WriteProgram(Work w);
    }
}