namespace ejercicio3
{
    public class sueldo
    {
        public static void Main()
        {
            int ss, ch, vh;
            Console.WriteLine("digite las horas trabajadas");
            ch=int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de la hora");
            vh=int.Parse(Console.ReadLine());

            ss = ch * vh;
            Console.WriteLine($"el sueldo semanal es de {ss}");
        }
    }
}
