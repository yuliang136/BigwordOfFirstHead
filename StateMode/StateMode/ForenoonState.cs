//=========================================================================
// File: ForenoonState.cs
//
// Summary:ForenoonState
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
    public class ForenoonState:State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", w.Hour);
            }
            else
            {
                //w.SetState(NewsStyleUriParser);
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }
}