class Program
{
    static void Main(string[] args)
    {
        Queue<char> mem1 = new Queue<char>();

        while(true)
        {
            Console.Write("Size : ");
            char size = char.Parse(Console.ReadLine());
            if(size != 'L' && size != 'M' && size != 'S'){
                break;
            }
            else{
                mem1.Push(size);
            }
        }
        while(true)
        {  
                char get = mem1.Pop() ;

                if(get == 'L'){
                    mem1.Push('M');
                    mem1.Push('M');
                    Console.Write(1);
                }
                else if (get == 'M'){
                    mem1.Push('S');
                    mem1.Push('S');
                    mem1.Push('S');
                    Console.Write(2);
                }
                else if (get == 'S'){ 
                    Console.Write(3);
                }
                
                if(mem1.GetLength() == 0)
                {
                    break;
                }  
        }
    }
}