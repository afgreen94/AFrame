using Abstractions.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
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
}
