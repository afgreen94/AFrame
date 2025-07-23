using AFrame.Base.Contracts.Abstractions;
using AFrame.Base.Contracts.Graphing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFrame.Base.Contracts.Math.Forms
{
    //idk what actually is the diff between form and curve 
    public interface IForm
    {

    }

    //public interface IFormDefinition { } for now -ag
     
    public interface IFormDescription { }

    //abstract forms beyond graphs lol ?  -ag 
    //for now keep the same 

    //public interface IGraphableForm 
    //{
    //    IFormGraph FormGraph { get; }
    //}

    //public interface IFormGraph : IGraph //need math graphing 
    //{

    //}

    public interface IFormGraphDescription : IGraphDescription { }
}
