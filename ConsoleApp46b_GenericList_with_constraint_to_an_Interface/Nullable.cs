namespace ConsoleApp46b_GenericList_with_constraint_to_an_Interface
{
    public class Nullable<T> where T : struct   //here we apply a constaraint to be a value type
    {
        //the idea here is that value types cannot be null, they are always 0, 1, 5, 3000, ...
        //we will use this class Nullable to give our value types the possibility to be also null

        private object _value;

        public Nullable()   //this is the default constructor
        {
            
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;  //here we need to cast it

            return default(T); //keyword "default" return the default value of a value type (e.g. for an int is 0, for bool is false, ...)
        }





    }

}
