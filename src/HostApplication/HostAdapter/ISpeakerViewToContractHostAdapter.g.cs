//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contracts.HostSideAdapters
{
    
    public class ISpeakerViewToContractHostAdapter : System.AddIn.Pipeline.ContractBase, Contracts.ISpeaker
    {
        private Contracts.HostViews.ISpeaker _view;
        public ISpeakerViewToContractHostAdapter(Contracts.HostViews.ISpeaker view)
        {
            _view = view;
        }
        public virtual string Say(Contracts.SayWhat what)
        {
            return _view.Say(Contracts.HostSideAdapters.SayWhatHostAdapter.ContractToViewAdapter(what));
        }
        internal Contracts.HostViews.ISpeaker GetSourceView()
        {
            return _view;
        }
    }
}

