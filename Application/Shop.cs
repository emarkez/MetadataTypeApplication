using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace Application
{
    public class Shop
    {
        public void PrintProperties(object vehiculo)
        {
            Type type = vehiculo.GetType();
            Console.WriteLine(string.Format("Caracteristicas del vehiculo {0}:", type.Name));

            //Obtenemos tipo de la clase
            
            PropertyInfo[] propertyInfos = type.GetProperties();
            PropertyInfo[] propertyMetadataInfos = null;

            //Miramos si la clase tienen metadatas
            var metadataTypes = (MetadataTypeAttribute[])type.GetCustomAttributes(typeof(MetadataTypeAttribute), true);
            MetadataTypeAttribute metadata = metadataTypes.FirstOrDefault();
            ///Si la clase tiene Metadatos
            if (metadata != null) propertyMetadataInfos = metadata.MetadataClassType.GetProperties();
                foreach (PropertyInfo propertyInfo in propertyInfos)
                {
                    if (propertyMetadataInfos != null && propertyMetadataInfos.Count(p => p.Name == propertyInfo.Name) > 0)
                    {
                        PropertyInfo propertyMetadataInfo = metadata.MetadataClassType.GetProperty(propertyInfo.Name);
                        if (propertyMetadataInfo.IsDefined(typeof(ElementAssociatedAttribute), true))
                        {
                            var attribute = (ElementAssociatedAttribute)propertyMetadataInfo.GetCustomAttributes(typeof(ElementAssociatedAttribute), true)[0];
                            if (attribute != null)
                            {
                                Console.WriteLine("La propiedad {0}, de valor {1}, se guarda en {2}.", propertyInfo.Name, propertyInfo.GetValue(vehiculo),
                                    attribute.OtherTable);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("La propiedad {0}, de valor {1}, se guarda en {2}.", propertyInfo.Name, propertyInfo.GetValue(vehiculo),
                            "su tabla normal");
                    }
                }
        }
    }
}
