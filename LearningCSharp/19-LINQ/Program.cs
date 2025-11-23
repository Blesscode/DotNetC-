using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_LINQ
{
    /*
     * LINQ TO OBJ : COLLECTIONS
            METHODS: WHERE | SELECT | ORDERBY  OrderByDescending | FIRST FirstOrDefault | COUNT | SUM MIN MAX AVG |
            ORDER : WHERE -> ORDER -> SELECT-> FIRST -> COUNT
     * LINQ TO SQL : DB
            
     */

    /*  TYPE OF LINQ METHODS
     *  [1] ACCEPT LAMDA : AS A SELECTOR / CONDITION FILETR
     
                Where(predicate)	                    filtering
                Select(selector)	                    projection
                OrderBy(keySelector)	                sorting
                OrderByDescending(keySelector)	        sorting
                ThenBy(keySelector)	                    second-level sort
                First(predicate)	                    find first matching
                Any(predicate)	                        check for match
                All(predicate)	                        ensure all match
                Count(predicate)	                    count matching
                Sum(selector)	                        compute total
                Average(selector)	                    compute avg
                FirstOrDefault(predicate)
                LastOrDefault()

     *  [2] DOES NOT ACCEPT LAMDA
    
                ToList()	convert to list
                ToArray()	convert to array
                First()	just get first
                Last()	just get last
                LastOrDefault()
                Count()	total count
                Max()	highest value (for basic types)
                Min()	lowest value (for basic types)
                FirstOrDefault()
     
     
     */

    /* TYPE OF WRITING STYLE: Query Syntax vs Method Syntax
     
        QUERY SYNTAX : DO NOT NEED TO WRITE LAMDA EXP : INTERNAL CONVERT BY OWN
        METHOD SYNTAX : NEED TO WRITE , USE LINQ METHOD
     


     */
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student[] students =  { 
                new Student{ name="Isha",age=1},
                 new Student{ name="Esha",age=2},
            };
            Console.WriteLine("LINQ : USING QUERY MY METHOD");
            var result =
            from s in students
            where s.age > 18
            orderby s.name
            select s.name;


            Console.WriteLine("LINQ : USING METHOD SYNTAX");
            var students2=students.Where(s=>s.age>18).OrderBy(s => s.name).Select(s=>s.name).FirstOrDefault().Length;

        }
    }
}
