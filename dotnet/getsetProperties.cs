namespace properties
{
    class GetSet
    {
        //public String Nameof{get;set;}
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