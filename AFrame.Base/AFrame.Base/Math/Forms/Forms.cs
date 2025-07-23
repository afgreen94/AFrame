using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFrame.Base.Abstractions;
using AFrame.Base.Contracts.Abstractions;
using AFrame.Base.Contracts.Graphing;
using AFrame.Base.Contracts.Math.Forms;
using AFrame.Base.Graphing;
using AFrame.Base.Math.Forms;

namespace AFrame.Base.Math.Forms
{
    //eventually form description should be layered -ag
    //for now using GSS default for simplicity's sake 
    public class Form :  IForm
    {

    }

    public class FormDescription : GSS_Description, IFormDescription
    {

    }

    //public abstract class GraphableForm : IGraphableForm  //form graph factory id pattern type deal. 
    //                                                                       //will take a longg time -ag 
    //                                                                       //additionally another opportunity for defn pattern 
    //{
    //    protected abstract IFormGraph formGraph { get; }
    //    public IFormGraph FormGraph => this.formGraph;
    //}

    //public abstract class FormGraph : Graph, IFormGraph
    //{
    //}

    public abstract class FormGraphDescription : IFormGraphDescription
    {

    }

    //public abstract class DescribableFormGraph : FormGraph, IDescribable<IFormGraphDescription>
    //{
    //    public abstract IFormGraphDescription Description { get; }
    //}
}
