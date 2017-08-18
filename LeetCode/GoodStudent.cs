using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class GoodStudent : Classmate
    {

        //protected String id;
        //protected String lname;
        //protected String fname;

        public override String ID
        {
            get { return this.id; }
            set { id = value; }
        }

        public override String FirstName
        {
            get { return this.fname; }
            set { fname = value; }
        }

        public override String LastName
        {
            get { return this.lname; }
            set { lname = value; }
        }
        //completed methods


        public override String Update()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " updated";
        }
        //completed methods


        //public  String Add()
        //{
        //    return "Employee " + id + " " +
        //              lname + " " + fname +
        //              " added";
        //}
        ////completed methods


        public  String Delete()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " deleted";
        }
        //completed methods


        public new String Search()
        {
            return "Employee " + id + " " +
                      lname + " " + fname +
                      " found";
        }

        //abstract method that is different 


        //from Fulltime and Contractor

        //therefore i keep it uncompleted and 

        //let each implementation 

        //complete it the way they calculate the wage.


        public override String CalculateWage()
        {
            return "";
        }
        
    }
}
