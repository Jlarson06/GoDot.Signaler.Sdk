namespace Godot.Signaler.Sdk
{
    using System;
    using GdObject = Godot.Object;

    public abstract class GdSignal
    {
        public static GdSignal operator +(GdSignal left, Action right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Connect(gdObject, right.Method.Name);
            return left;
        }
        public static GdSignal operator -(GdSignal left, Action right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Disconnect(gdObject, right.Method.Name);
            return left;
        }

        public abstract void Emit();
        public abstract void DeferredEmit();
        public abstract void Connect(GdObject target, string targetHandlerMethodName);
        public abstract void Disconnect(GdObject target, string targetHandlerMethodName);

    }

    public abstract class GdSignal<T> where T : GdObject
    {
        public static GdSignal<T> operator +(GdSignal<T> left, Action<T> right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Connect(gdObject, right.Method.Name);
            return left;
        }
        public static GdSignal<T> operator -(GdSignal<T> left, Action<T> right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Disconnect(gdObject, right.Method.Name);
            return left;
        }

        public abstract void Emit(T dataToEmit);
        public abstract void DeferredEmit(T dataToEmit);
        public abstract void Connect(GdObject target, string targetHandlerMethodName);
        public abstract void Disconnect(GdObject target, string targetHandlerMethodName);

    }

    public abstract class GdSignal<T1, T2>
        where T1 : GdObject
        where T2 : GdObject
    {
        public static GdSignal<T1, T2> operator +(GdSignal<T1, T2> left, Action<T1, T2> right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Connect(gdObject, right.Method.Name);
            return left;
        }
        public static GdSignal<T1, T2> operator -(GdSignal<T1, T2> left, Action<T1, T2> right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Disconnect(gdObject, right.Method.Name);
            return left;
        }

        public abstract void Emit(T1 data1ToEmit, T2 data2ToEmit);
        public abstract void DeferredEmit(T1 data1ToEmit, T2 data2ToEmit);
        public abstract void Connect(GdObject target, string targetHandlerMethodName);
        public abstract void Disconnect(GdObject target, string targetHandlerMethodName);

    }
    public abstract class GdSignal<T1, T2, T3>
        where T1 : GdObject
        where T2 : GdObject
        where T3 : GdObject
    {
        public static GdSignal<T1, T2, T3> operator +(GdSignal<T1, T2, T3> left, Action<T1, T2, T3> right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Connect(gdObject, right.Method.Name);
            return left;
        }
        public static GdSignal<T1, T2, T3> operator -(GdSignal<T1, T2, T3> left, Action<T1, T2, T3> right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Disconnect(gdObject, right.Method.Name);
            return left;
        }

        public abstract void Emit(T1 data1ToEmit, T2 data2ToEmit, T3 data3ToEmit);
        public abstract void DeferredEmit(T1 data1ToEmit, T2 data2ToEmit, T3 data3ToEmit);
        public abstract void Connect(GdObject target, string targetHandlerMethodName);
        public abstract void Disconnect(GdObject target, string targetHandlerMethodName);

    }
    public abstract class GdSignal<T1, T2, T3, T4>
        where T1 : GdObject
        where T2 : GdObject
        where T3 : GdObject
        where T4 : GdObject
    {
        public static GdSignal<T1, T2, T3, T4> operator +(GdSignal<T1, T2, T3, T4> left, Action<T1, T2, T3, T4> right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Connect(gdObject, right.Method.Name);
            return left;
        }
        public static GdSignal<T1, T2, T3, T4> operator -(GdSignal<T1, T2, T3, T4> left, Action<T1, T2, T3, T4> right)
        {
            var gdObject = right.Target as GdObject;

            if (gdObject == null)
            {
                return left;
            }
            left.Disconnect(gdObject, right.Method.Name);
            return left;
        }

        public abstract void Emit(T1 data1ToEmit, T2 data2ToEmit, T3 data3ToEmit, T4 data4ToEmit);
        public abstract void DeferredEmit(T1 data1ToEmit, T2 data2ToEmit, T3 data3ToEmit, T4 data4ToEmit);
        public abstract void Connect(GdObject target, string targetHandlerMethodName);
        public abstract void Disconnect(GdObject target, string targetHandlerMethodName);

    }
}
