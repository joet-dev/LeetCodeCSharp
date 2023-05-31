using System;
public class RB{
    public List<string> rec = new List<string>(); 

    public void a(string re)
    {
        if(re.Split(' ').Length > 1) {
            rec.Add(re); 
        }
    }
    public List<IGrouping<string, string>> SortRec() {
        return rec.GroupBy(re => re.Split(' ').First()).ToList(); 
    }
}

namespace test
{
    class testProgram {
        static void Main(string[] args) {
            RB rb = new RB(); 
            
            string[] lst = new string[]{"metal book", "metal house", "plastic toy", "copper wire"}; 
            for (int i=0; i<lst.Length; i++) {
                rb.a(lst[i]);
            }
            rb.SortRec(); 

            foreach (string x in rb.rec){

                Console.WriteLine(x);     
            }
                
        }
    }
}


