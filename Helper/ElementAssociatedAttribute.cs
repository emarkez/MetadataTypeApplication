using System;

namespace Helper
{
    /// <summary>
    /// Atributo para indicar que taula/clase y que campo/propiedad tiene asociado
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ElementAssociatedAttribute : Attribute
    {
        private readonly string _otherTable;
        private readonly string _otherProperty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="otherTable">Tabla/Clase asociada</param>
        /// <param name="otherProperty">Campo/Propiedad asociada</param>
        public ElementAssociatedAttribute(string otherTable, string otherProperty)
        {
            this._otherTable = otherTable;
            this._otherProperty = otherProperty;
        }

        /// <summary>
        /// Obtiene la tabla/clase asociada
        /// </summary>
        public string OtherTable
        {
            get { return this._otherTable; }
        }

        /// <summary>
        /// Obtiene el campo/propiedad asociada
        /// </summary>
        public string OtherProperty
        {
            get { return this._otherProperty; }
        }
    }
}
