using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace laba4._1_OOP
{
    class Storage
    {
        public CCircle[] objs;
        public int size;
	    public int c;

        public Storage(int size)
	    {
            objs = new CCircle[size];
            for (int i = 0; i < size; i++)
                objs[i] = null;
            this.size = size;
            c = 0;
        }

        public void setObject(int i, CCircle SomeObject)
        {
            if (i < size && objs[i] == null)
                objs[i] = SomeObject;
            c++;
        }

        //public CCircle getObject(int i)
        //{
        //    if (i < size && objs[i] != null)
        //        return objs[i];
        //}

        public void delOblect(int i)
        {
            if (i < size && objs[i] != null)
                objs[i] = null;
            c--;
        }

        public int getSize()
        {
            return size;
        }

        public void resize(int newSize)
        {
            CCircle[] new_objs = new CCircle[newSize];
            for (int i = 0; i < size; i++)
            {
                new_objs[i] = objs[i];
            }
            for (int i = size; i < newSize; i++)
            {
                new_objs[i] = null;
            }
            size = newSize;
        }
    }
}
