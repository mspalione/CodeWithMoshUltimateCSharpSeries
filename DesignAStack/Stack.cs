//using System;
//using System.Collections.Generic;

//namespace DesignAStack
//{
//    public class Stack
//    {
//        public List<object> objects { get; set; }

//        public void Push(object obj)
//        {
//            objects.Add(obj);
//            if (obj == null)
//            {
//                throw new InvalidOperationException();
//            }
            
//        }
//        public object Pop()
//        {
//            object topObject;
//            if (objects.Count > 1)
//            {
//                throw new InvalidOperationException();
//            }

//            topObject = objects[0];
//            return topObject;
//        }

//        public void Clear()
//        {
//            objects.Clear();
//        }
//    }
//}
