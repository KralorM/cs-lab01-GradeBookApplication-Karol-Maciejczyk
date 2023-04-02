using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
     public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(String name,bool StandardGradebook):base(name,StandardGradebook) //Adding bool to the StandardGradebook Constructor
        {
            this.Name = name;
            Type = Enums.GradeBookType.Standard;
           
        }
        


    }




}
