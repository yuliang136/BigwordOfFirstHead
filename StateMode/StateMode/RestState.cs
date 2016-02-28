//=========================================================================
// File: RestState.cs
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
using System.Linq;
using System.Collections.Generic;

namespace StateMode
{
    public class RestState:State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点, 下班回家了", w.Hour);
        }

        #region Data Variables

        #endregion

        #region Functions

        #endregion
    }
}