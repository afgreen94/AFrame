﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFrame.Base.Contracts.Abstractions;

namespace AFrame.Base.Abstractions
{
    public abstract class GSSDescriptionBase : IDescribable
    {
        public abstract Guid Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
    }

    public class GSS_Description : GSSDescriptionBase, IDescribable  //Guid-string-string 
    {
        public override Guid Id { get; set; }
        public override string Name { get; set; }
        public override string Description { get; set; }
    }

    public class Result : IResult { }

    public class Pair<T> : IPair<T>
    {
        public T Item1 { get; set; }
        public T Item2 { get; set; }

        public Pair() { }
        public Pair(T item1, T item2) { }
    }
}
