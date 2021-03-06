﻿using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Prototypist.FunctionFlow
{
    public interface IFlowBuilder
    {
        bool Parallel { get; set; }

        void SetConstant<T>(T t);
        void SetSource<T>(T t) where T : Delegate;
        void AddStep(Delegate expression);
        void AddStepPacked<T1,T2>(Delegate expression);
        void AddStepPacked<T1, T2, T3>(Delegate expression);
        void AddStepPacked<T1, T2, T3, T4>(Delegate expression);
        void AddStepPacked<T1, T2, T3, T4, T5>(Delegate expression);
        void AddStepPacked<T1, T2, T3, T4, T5, T6>(Delegate expression);
        void AddStepPacked<T1, T2, T3, T4, T5, T6, T7>(Delegate expression);
        void SetContainer(IContainer container);

        T Build<T>() where T : Delegate;
        void Run(params object[] inputs);
        T Run<T>(params object[] inputs);
        (T1, T2) Run<T1, T2>(params object[] inputs);
        (T1, T2, T3) Run<T1, T2, T3>(params object[] inputs);
        (T1, T2, T3, T4) Run<T1, T2, T3, T4>(params object[] inputs);
        (T1, T2, T3, T4, T5) Run<T1, T2, T3, T4,T5>(params object[] inputs);
        (T1, T2, T3, T4, T5, T6) Run<T1, T2, T3, T4, T5,T6>(params object[] inputs);
        (T1, T2, T3, T4, T5, T6, T7) Run<T1, T2, T3, T4, T5, T6, T7>(params object[] inputs);
        
    }
}