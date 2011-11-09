using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using OpenSpan.Serialization;
using OpenSpan.Design;
using OpenSpan.Server.Controls;
using OpenSpan.Server.Events;
using System.Drawing;
using OpenSpan.TypeManagement;

namespace OpenSpan.Events.Server51.LoopbackPublisher
{
    [Scope(ConnectableScope.Global)]
    [ToolboxBitmap(typeof(LoopbackPublisher), "EventConnector.ico")]
    [ToolboxItemFilter("OpenSpan.Automation.Automator", ToolboxItemFilterType.Require)]
    [ObjectExplorerGroupMember(ObjectExplorerGroupName.Events)]
    public class LoopbackPublisher : BaseConnector
    {
        [Description("Fired when any event is sent to the event system")]
        [MemberVisibility(MemberVisibilityLevel.DefaultOn)]
        public event EventDataOccurredHandler EventOccurred;

        protected override void ProcessEvent(EventDataArgs args)
        {
            EventOccurred(this, args);
        }

        protected override void OnPreDeserializationComplete()
        {
            //nothing to do here
        }
    }
}
