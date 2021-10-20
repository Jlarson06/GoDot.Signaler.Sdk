namespace Godot.Signaler.Sdk
{
    using GdObject = Godot.Object;

    public class Signaler : Node
    {
        protected GdSignal CreateSignal(string nameofSignal) 
        {
            return new SignalHelper(this, nameofSignal);
        }

        protected GdSignal<T> CreateSignal<T>(string nameofSignal) where T : GdObject
        {
            return new SignalHelper<T>(this, nameofSignal);
        }

        protected GdSignal<T1, T2> CreateSignal<T1, T2>(string nameofSignal)
            where T1 : GdObject
            where T2 : GdObject
        {
            return new SignalHelper<T1, T2>(this, nameofSignal);
        }

        protected GdSignal<T1, T2, T3> CreateSignal<T1, T2, T3>(string nameofSignal)
            where T1 : GdObject
            where T2 : GdObject
            where T3 : GdObject
        {
            return new SignalHelper<T1, T2, T3>(this, nameofSignal);
        }

        protected GdSignal<T1, T2, T3, T4> CreateSignal<T1, T2, T3, T4>(string nameofSignal)
            where T1 : GdObject
            where T2 : GdObject
            where T3 : GdObject
            where T4 : GdObject
        {
            return new SignalHelper<T1, T2, T3, T4>(this, nameofSignal);
        }
    }
}
