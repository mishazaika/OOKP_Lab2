using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOKP_Lab2
{
    [Serializable]
    class Immutable: IClone, IComparable<Immutable>, ISerializable
    {
        public string name;
        public string Name { get; private set; }

        public Immutable(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Immutable immutable = (Immutable)obj;
            return (this.Name == immutable.Name);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }

        public object clone()
        {
            return new Immutable(Name = this.Name);
        }

        public int CompareTo([AllowNull] Immutable other)
        {
            Immutable immutable = other as Immutable;
            if(immutable != null)
            {
                return this.Name.CompareTo(immutable.Name);

            }
            else
            {
                throw new Exception("Null value!!!");
            }
        }

        public void serializable()
        {
            Immutable immutable = new Immutable("Misha");
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("c://Users/misha/Desktop/lab2.txt", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, immutable);
            }

        }
    }
}
