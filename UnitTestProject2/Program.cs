// See https://aka.ms/new-console-template for more information




class Programmer 
{
    public string Fam;
    public int numOfProg;
    public int numOfLang;
    public int Q;

    public int Quality1()
    {
        Q = numOfProg * numOfLang;
        return Q;
    }
}

class Rasch 
{
    Programmer p1 = new Programmer();
    int P;
    int Qp;
    public int Quality2(int Q, int nFp) 
    {
        bool Prov = false;
        Console.WriteLine("Введите число программ программиста, которые работают правильно:");
        while (Prov == false) 
        {
            P = Convert.ToInt32(Console.ReadLine());
            if (P <= nFp) 
            { 
             Prov = true;
            }
            else 
            { 
             Prov=false;
            }
        }
        
            
        Qp = Q * P;
        return Qp;
    }
}

