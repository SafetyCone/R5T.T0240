using System;

using R5T.T0143;


namespace R5T.T0240.N001
{
    /// <summary>
    /// <inheritdoc cref="T0240.WithXMarkerAttribute" path="/summary"/>
    /// <para>
    /// But, in cases where there are multiple attribtues, this attribute allows specifying both the name and type of X property.
    /// </para>
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="T0240.WithXMarkerAttribute" path="/remarks"/>
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class WithXMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <inheritdoc cref="T0240.WithXMarkerAttribute.IsIWithX"/>
        public bool IsIWithX { get; }

        public Type TypeOfX { get; }

        public string NameOfX { get; }


        public WithXMarkerAttribute(
            Type typeOfX,
            string nameOfX,
            bool isIWithX = true)
        {
            this.TypeOfX = typeOfX;
            this.NameOfX = nameOfX;
            this.IsIWithX = isIWithX;
        }
    }
}
