using System;
using System.AddIn.Contract;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{

    [AddInContract]
    public interface ISpeaker : IContract
    {
        string Say(SayWhat what);
    }

    [Serializable]
    public enum SayWhat
    {
        Hello,
        Goodbye
    }
}
