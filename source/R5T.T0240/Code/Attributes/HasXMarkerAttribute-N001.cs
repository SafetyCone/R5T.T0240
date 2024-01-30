using System;

using R5T.T0143;


namespace R5T.T0240.N001
{
    /// <summary>
    /// <inheritdoc cref="T0240.HasXMarkerAttribute" path="/summary"/>
    /// <para>
    /// But, in cases where there are multiple attribtues, this attribute allows specifying both the name and type of X property.
    /// </para>
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="T0240.HasXMarkerAttribute" path="/remarks"/>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class HasXMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <inheritdoc cref="T0240.HasXMarkerAttribute.IsIHasX"/>
        public bool IsIHasX { get; }

        public Type TypeOfX { get; }

        public string NameOfX { get; }


        public HasXMarkerAttribute(
            Type typeOfX,
            string nameOfX,
            bool isIHasX = true)
        {
            this.TypeOfX = typeOfX;
            this.NameOfX = nameOfX;
            this.IsIHasX = isIHasX;
        }
    }
}
