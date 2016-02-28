//=========================================================================
// File: EveningState.cs
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
    public class EveningState : State
    {
        public override void WriteProgram(Work w)
        {
            //if (w.Hour < 17)
            //{
            //    Console.WriteLine("当前时间：{0}下午工作", w.Hour);
            //}
            //else
            //{
            //    w.SetState(new EveningState());
            //    w.WriteProgram();
            //}
            if (w.Finish)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine("当前时间：{0} 加班哦，疲累之极", w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
        }

        #region Data Variables

        #endregion

        #region Functions

        #endregion
    }
}