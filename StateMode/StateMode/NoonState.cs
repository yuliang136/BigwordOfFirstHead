//=========================================================================
// File: NoonState.cs
//
// Summary:NoonState
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
    public class NoonState:State
    {
        public override void WriteProgram(Work w)
        {
            //throw new NotImplementedException();
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间：{0}午休", w.Hour);
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
            
        }

        #region Data Variables

        #endregion

        #region Functions

        #endregion
    }
}