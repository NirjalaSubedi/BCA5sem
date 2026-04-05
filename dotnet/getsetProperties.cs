namespace properties
{
    class GetSet
    {
       private int _name;

        public int Name 
        {
            get 
            {
                return _name; 
            }
            set 
            {
                _name = value; 
            }
        }
    }
}