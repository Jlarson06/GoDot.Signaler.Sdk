namespace Godot.Signaler.Sdk
{
    using System;
    using Godot;
    using GdObject = Godot.Object;

    internal class SignalHelper : GdSignal
    {
        private Node _parent;
        private string _signalName;
        public SignalHelper(Node parent, string signalName)
        {
            if (string.IsNullOrWhiteSpace(signalName))
            {
                throw new ArgumentException("Must be a signal name", nameof(signalName));
            }

            _parent = parent ?? throw new ArgumentNullException(nameof(parent));
            _signalName = signalName;
        }

        public override void Connect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Connect(_signalName, target, targetHandlerMethodName);
        }

        public override void Disconnect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Disconnect(_signalName, target, targetHandlerMethodName);
        }

        public override void Emit()
        {
            _parent.EmitSignal(_signalName);
        }

        /// <inheritdoc />
        public override void DeferredEmit()
        {
            GD.Print($"Deferring {_signalName}");
            _parent.CallDeferred("emit_signal", _signalName);
        }
    }

    internal class SignalHelper<T> : GdSignal<T> where T : GdObject
    {
        private Node _parent;
        private string _signalName;
        public SignalHelper(Node parent, string signalName)
        {
            if (string.IsNullOrWhiteSpace(signalName))
            {
                throw new ArgumentException("Must be a signal name", nameof(signalName));
            }

            _parent = parent ?? throw new ArgumentNullException(nameof(parent));
            _signalName = signalName;
        }

        public override void Connect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Connect(_signalName, target, targetHandlerMethodName);
        }

        public override void Disconnect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Disconnect(_signalName, target, targetHandlerMethodName);
        }

        public override void Emit(T dataToEmit)
        {
            _parent.EmitSignal(_signalName, dataToEmit);
        }

        /// <inheritdoc />
        public override void DeferredEmit(T dataToEmit)
        {
            GD.Print($"Deferring {_signalName} parameters: [{dataToEmit}]");
            _parent.CallDeferred("emit_signal", _signalName, dataToEmit);
        }
    }

    internal class SignalHelper<T1, T2> : GdSignal<T1, T2>
        where T1 : GdObject
        where T2 : GdObject
    {
        private Node _parent;
        private string _signalName;
        public SignalHelper(Node parent, string signalName)
        {
            if (string.IsNullOrWhiteSpace(signalName))
            {
                throw new ArgumentException("Must be a signal name", nameof(signalName));
            }

            _parent = parent ?? throw new ArgumentNullException(nameof(parent));
            _signalName = signalName;
        }

        public override void Connect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Connect(_signalName, target, targetHandlerMethodName);
        }

        public override void Disconnect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Disconnect(_signalName, target, targetHandlerMethodName);
        }

        public override void Emit(T1 data1ToEmit, T2 data2ToEmit)
        {
            _parent.EmitSignal(_signalName, data1ToEmit, data2ToEmit);
        }

        /// <inheritdoc />
        public override void DeferredEmit(T1 dataToEmit, T2 data2ToEmit)
        {
            GD.Print($"Deferring {_signalName} parameters: [{dataToEmit}] [{data2ToEmit}]");
            _parent.CallDeferred("emit_signal", _signalName, dataToEmit, data2ToEmit);
        }
    }
    internal class SignalHelper<T1, T2, T3> : GdSignal<T1, T2, T3>
        where T1 : GdObject
        where T2 : GdObject
        where T3 : GdObject
    {
        private Node _parent;
        private string _signalName;
        public SignalHelper(Node parent, string signalName)
        {
            if (string.IsNullOrWhiteSpace(signalName))
            {
                throw new ArgumentException("Must be a signal name", nameof(signalName));
            }

            _parent = parent ?? throw new ArgumentNullException(nameof(parent));
            _signalName = signalName;
        }

        public override void Connect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Connect(_signalName, target, targetHandlerMethodName);
        }

        public override void Disconnect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Disconnect(_signalName, target, targetHandlerMethodName);
        }

        public override void Emit(T1 data1ToEmit, T2 data2ToEmit, T3 data3ToEmit)
        {
            _parent.EmitSignal(_signalName, data1ToEmit, data2ToEmit, data3ToEmit);
        }

        /// <inheritdoc />
        public override void DeferredEmit(T1 dataToEmit, T2 data2ToEmit, T3 data3ToEmit)
        {
            GD.Print($"Deferring {_signalName} parameters: [{dataToEmit}] [{data2ToEmit}] [{data3ToEmit}]");
            _parent.CallDeferred("emit_signal", _signalName, dataToEmit, data2ToEmit, data3ToEmit);
        }
    }
    internal class SignalHelper<T1, T2, T3, T4> : GdSignal<T1, T2, T3, T4>
        where T1 : GdObject
        where T2 : GdObject
        where T3 : GdObject
        where T4 : GdObject
    {
        private Node _parent;
        private string _signalName;
        public SignalHelper(Node parent, string signalName)
        {
            if (string.IsNullOrWhiteSpace(signalName))
            {
                throw new ArgumentException("Must be a signal name", nameof(signalName));
            }

            _parent = parent ?? throw new ArgumentNullException(nameof(parent));
            _signalName = signalName;
        }

        public override void Connect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Connect(_signalName, target, targetHandlerMethodName);
        }

        public override void Disconnect(GdObject target, string targetHandlerMethodName)
        {
            _parent.Disconnect(_signalName, target, targetHandlerMethodName);
        }

        public override void Emit(T1 data1ToEmit, T2 data2ToEmit, T3 data3ToEmit, T4 data4ToEmit)
        {
            _parent.EmitSignal(_signalName, data1ToEmit, data2ToEmit, data3ToEmit, data4ToEmit);
        }

        /// <inheritdoc />
        public override void DeferredEmit(T1 dataToEmit, T2 data2ToEmit, T3 data3ToEmit, T4 data4ToEmit)
        {
            GD.Print($"Deferring {_signalName} parameters: [{dataToEmit}] [{data2ToEmit}] [{data3ToEmit}] [{data4ToEmit}]");
            _parent.CallDeferred("emit_signal", _signalName, dataToEmit, 
                data2ToEmit, data3ToEmit, data4ToEmit);
        }
    }
}
