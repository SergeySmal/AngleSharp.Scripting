namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Html;
    using Jint;
    using Jint.Native;
    using Jint.Native.Object;
    using Jint.Runtime;
    using Jint.Runtime.Descriptors;
    using Jint.Runtime.Interop;
    using System;

    sealed partial class HTMLTableHeaderCellElementPrototype : HTMLTableHeaderCellElementInstance
    {
        public HTMLTableHeaderCellElementPrototype(Engine engine)
            : base(engine)
        {
            FastAddProperty("toString", Engine.AsValue(ToString), true, true, true);
            FastAddProperty("append", Engine.AsValue(Append), true, true, true);
            FastAddProperty("prepend", Engine.AsValue(Prepend), true, true, true);
            FastAddProperty("querySelector", Engine.AsValue(QuerySelector), true, true, true);
            FastAddProperty("querySelectorAll", Engine.AsValue(QuerySelectorAll), true, true, true);
            FastAddProperty("before", Engine.AsValue(Before), true, true, true);
            FastAddProperty("after", Engine.AsValue(After), true, true, true);
            FastAddProperty("replace", Engine.AsValue(Replace), true, true, true);
            FastAddProperty("remove", Engine.AsValue(Remove), true, true, true);
            FastSetProperty("scope", Engine.AsProperty(GetScope, SetScope));
            FastSetProperty("children", Engine.AsProperty(GetChildren));
            FastSetProperty("firstElementChild", Engine.AsProperty(GetFirstElementChild));
            FastSetProperty("lastElementChild", Engine.AsProperty(GetLastElementChild));
            FastSetProperty("childElementCount", Engine.AsProperty(GetChildElementCount));
            FastSetProperty("nextElementSibling", Engine.AsProperty(GetNextElementSibling));
            FastSetProperty("previousElementSibling", Engine.AsProperty(GetPreviousElementSibling));
            FastSetProperty("style", Engine.AsProperty(GetStyle, SetStyle));
        }

        public static HTMLTableHeaderCellElementPrototype CreatePrototypeObject(EngineInstance engine, HTMLTableHeaderCellElementConstructor constructor)
        {
            var obj = new HTMLTableHeaderCellElementPrototype(engine.Jint)
            {
                Prototype = engine.Constructors.HTMLTableCellElement.PrototypeObject,
                Extensible = true,
            };
            obj.FastAddProperty("constructor", constructor, true, false, true);
            return obj;
        }

        JsValue Append(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            var nodes = DomTypeConverter.ToNodeArray(arguments.At(0));
            reference.Append(nodes);
            return JsValue.Undefined;
        }

        JsValue Prepend(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            var nodes = DomTypeConverter.ToNodeArray(arguments.At(0));
            reference.Prepend(nodes);
            return JsValue.Undefined;
        }

        JsValue QuerySelector(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            var selectors = TypeConverter.ToString(arguments.At(0));
            return Engine.Select(reference.QuerySelector(selectors));
        }

        JsValue QuerySelectorAll(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            var selectors = TypeConverter.ToString(arguments.At(0));
            return Engine.Select(reference.QuerySelectorAll(selectors));
        }

        JsValue Before(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            var nodes = DomTypeConverter.ToNodeArray(arguments.At(0));
            reference.Before(nodes);
            return JsValue.Undefined;
        }

        JsValue After(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            var nodes = DomTypeConverter.ToNodeArray(arguments.At(0));
            reference.After(nodes);
            return JsValue.Undefined;
        }

        JsValue Replace(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            var nodes = DomTypeConverter.ToNodeArray(arguments.At(0));
            reference.Replace(nodes);
            return JsValue.Undefined;
        }

        JsValue Remove(JsValue thisObj, JsValue[] arguments)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            reference.Remove();
            return JsValue.Undefined;
        }

        JsValue GetScope(JsValue thisObj)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            return Engine.Select(reference.Scope);
        }

        void SetScope(JsValue thisObj, JsValue argument)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            var value = TypeConverter.ToString(argument);
            reference.Scope = value;
        }

        JsValue GetChildren(JsValue thisObj)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            return Engine.Select(reference.Children);
        }


        JsValue GetFirstElementChild(JsValue thisObj)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            return Engine.Select(reference.FirstElementChild);
        }


        JsValue GetLastElementChild(JsValue thisObj)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            return Engine.Select(reference.LastElementChild);
        }


        JsValue GetChildElementCount(JsValue thisObj)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            return Engine.Select(reference.ChildElementCount);
        }


        JsValue GetNextElementSibling(JsValue thisObj)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            return Engine.Select(reference.NextElementSibling);
        }


        JsValue GetPreviousElementSibling(JsValue thisObj)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            return Engine.Select(reference.PreviousElementSibling);
        }


        JsValue GetStyle(JsValue thisObj)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            return Engine.Select(reference.Style);
        }

        void SetStyle(JsValue thisObj, JsValue argument)
        {
            var reference = thisObj.TryCast<HTMLTableHeaderCellElementInstance>(Fail).RefHTMLTableHeaderCellElement;
            var value = TypeConverter.ToString(argument);
            reference.Style.CssText = value;
        }

        JsValue ToString(JsValue thisObj, JsValue[] arguments)
        {
            return "[object HTMLTableHeaderCellElement]";
        }

        void Fail(JsValue obsolete)
        {
            throw new JavaScriptException(Engine.TypeError);
        }
    }
}