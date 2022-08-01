using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Admin : User
    {
        private bool _isSuperAdmin;
        private string _section;
        public bool IsSuperAdmin
        {
            get { return _isSuperAdmin; }
            set { _isSuperAdmin = value; }
        }
        public string Section
        {
            get { return _section; }
            set { _section = value; }
        }

        public Admin(string userName, string password, bool isSuperAdmin, string section) : base(userName, password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;

        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"IsSuperAdmin:{IsSuperAdmin} Section:{Section} ");
        }
    }
}

