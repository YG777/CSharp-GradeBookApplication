using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
  
        public StandardGradeBook(string name, bool isWeighted) :base(name, isWeighted)
            
        {
            Name = name;
            Type = GradeBookType.Standard;
            IsWeighted = isWeighted;
        }


    }
}
