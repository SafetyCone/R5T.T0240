using System;

using R5T.T0143;


namespace R5T.T0240
{
    /// <summary>
    /// Attribute indicating an interface type is an IHasX type.
    /// IHasX interfaces should only have a single property with a only a getter, but with freedom to choose the property name.
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of IHasX types.
    /// </remarks>
    /// <seealso cref="N001.HasXMarkerAttribute"/>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class HasXMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a type is *not* an IHasX type.
        /// This is useful for marking types that end up canonical IHasX type code file locations, but are not actually IHasX types.
        /// </summary>
        public bool IsIHasX { get; }


        public HasXMarkerAttribute(
            bool isIHasX = true)
        {
            this.IsIHasX = isIHasX;
        }
    }
}
