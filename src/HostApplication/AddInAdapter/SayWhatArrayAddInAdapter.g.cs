//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contracts.AddInSideAdapters
{
    
    public class SayWhatArrayAddInAdapter
    {
        public static Contracts.AddInViews.SayWhat[] ContractToViewAdapter(Contracts.SayWhat[] contract)
        {
            if ((contract == null))
            {
                return null;
            }
            Contracts.AddInViews.SayWhat[] result = new Contracts.AddInViews.SayWhat[contract.Length];
            for (int i = 0; (i < contract.Length); i = (i + 1))
            {
                result[i] = Contracts.AddInSideAdapters.SayWhatAddInAdapter.ContractToViewAdapter(contract[i]);
            }
            return result;
        }
        public static Contracts.SayWhat[] ViewToContractAdapter(Contracts.AddInViews.SayWhat[] view)
        {
            if ((view == null))
            {
                return null;
            }
            Contracts.SayWhat[] result = new Contracts.SayWhat[view.Length];
            for (int i = 0; (i < view.Length); i = (i + 1))
            {
                result[i] = Contracts.AddInSideAdapters.SayWhatAddInAdapter.ViewToContractAdapter(view[i]);
            }
            return result;
        }
    }
}

