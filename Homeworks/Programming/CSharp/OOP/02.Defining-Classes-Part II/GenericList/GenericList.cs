using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    {
        const int DefaultLenght = 20;
        private T[] elements;
        private int count = 0;

        //constr
        public GenericList(int lenght)
        {
            this.elements = new T[DefaultLenght];
        }
        public GenericList()
            : this(DefaultLenght)
        {
        }

        //prop
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }

            set
            {
                this.elements[index] = value;
            }
        }

        //methods
        public T Min()
        {
            if (count == 0)
            {
                throw new Exception("No elements in the list");
            }
            else if (count == 1)
            {
                return this.elements[0];
            }
            else
            {
                T min = elements[0];
                for (int i = 1; i < elements.Count(); i++)
                {
                    if ((min as IComparable<T>).CompareTo(elements[i]) > 0)
                    {
                        min = elements[i];
                    }
                }
                return min;
            }
        }

        public T Max()
        {
            if (count == 0)
            {
                throw new Exception("No elements in the list");
            }
            else if (count == 1)
            {
                return this.elements[0];
            }
            else
            {
                T max = elements[0];
                for (int i = 1; i < elements.Count(); i++)
                {
                    if ((max as IComparable<T>).CompareTo(elements[i]) < 0)
                    {
                        max = elements[i];
                    }
                }
                return max;
            }
        }

        public void AddElement(T element)
        {
            if (count == this.elements.Count())
            {
                GetDoubleSize();
            }
            this.elements[count] = element;
            count++;
        }

        public void RemoveElement(int index)
        {
            T[] temp = new T[count-1];
            int j = 0;
            for (int i = 0; i < count; i++)
            {
                if (i == index)
                {
                    i++;
                }
                temp[j] = this.elements[i];
                j++;
            }
            this.elements = temp;
            count--;
        }

        //public void AccessElement(int index)
        //{
        //    Console.WriteLine(this.elements[index]);
        //}

        public void InsertElement(T element, int index)
        {
            if (count == this.elements.Count())
            {
                GetDoubleSize();
            }
            T[] temp = new T[count + 1];
            int j = 0;
            for (int i = 0; i < count+1; i++)
            {
                if (i == index)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = this.elements[j];
                    j++;
                }     
            }
            this.elements = temp;
            count++;
        }

        //public T FindElement(T value)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        T element = this.elements[i];
        //        if (this.elements[i] == value)
        //        { 
        //            return this.elements[i];
        //        }
        //    }
        //}

        public void ClearList()
        {
            this.elements = new T[DefaultLenght];
            count = 0;
        }

        public void GetDoubleSize()
        {
            T[] temp = new T[this.elements.Length*2];
            Array.Copy(this.elements, 0, temp, 0, this.elements.Length);
            this.elements = temp;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                text.Append(this.elements[i].ToString() + " ");
            }
            return text.ToString();
        }
    }
}
