namespace CoreSystem
{
    public  class PersonName
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        
        public PersonName(string fname,string mname,string lname)
        {
            FirstName = fname;
            MiddleName = mname;
            LastName = lname;
        }

        public override string ToString()
        {
            return FirstName + " " + (MiddleName == null ? "" : MiddleName + " ") + LastName;
        }
    }
}