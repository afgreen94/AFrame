using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AFrame.Base.Abstractions;
using AFrame.Base.Contracts.Abstractions;
using AFrame.Base.Contracts.Math.Forms;
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

    public abstract class DescribableForm : IDescribableForm  //-ag typing!!!  
    {
        //private const string _default = "Describable Form";  //need encoding scheme.. !!! -ag 
        //protected virtual string description => _default;
        //public new string Description => this.description;

        protected abstract IFormDescription description { get; }
        public IFormDescription Description => this.description;
    }

    public abstract class GraphableForm : DescribableForm, IGraphableForm  //form graph factory id pattern type deal. 
                                                                           //will take a longg time -ag 
                                                                           //additionally another opportunity for defn pattern 
    {
        protected abstract IFormGraph formGraph { get; }
        public IFormGraph FormGraph => this.formGraph;
    }

    public abstract class FormGraph :  IFormGraph
    {

    }

    public abstract class FormGraphDescription : IFormGraphDescription
    {

    }

    public abstract class DescribableFormGraph : FormGraph, IDescribableFormGraph
    {

    }
}
