namespace Cramer_s_Rule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAY TO TAKE INPUT FOR EACH X//
            Double[] x = new Double[3];
            for(int i=0; i<x.Length; i++)
            {
                Console.Write("ENTER X{0}: ",i+1);
                x[i] = Convert.ToDouble(Console.In.ReadLine());
            }

            //ARRAY TO TAKE INPUT FOR EACH Y
            Double[] y = new Double[3];
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write("ENTER Y{0}: ", i+1);
                y[i] = Convert.ToDouble(Console.In.ReadLine());
            }

            //ARRAY TO TAKE INPUT FOR EACH Z
            Double[] z = new Double[3];
            for (int i = 0; i < z.Length; i++)
            {
                Console.Write("ENTER Z{0}: ", i + 1);
                z[i] = Convert.ToDouble(Console.In.ReadLine());
            }

            //ARRAY TO TAKE INPUT FOR EACH EQUATION ANSWER(THE ONE AFTER EQUAL)
            Double[] q = new Double[3];
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write("ENTER Q{0}: ", i + 1);
                q[i] = Convert.ToDouble(Console.In.ReadLine());
            }

            //DETERMINANT FOR THE FIRST MATRIX
            double D = x[0]* ( y[1] * z[2] - z[1] * y[2] ) -  (y[0]) * ( x[1] * z[2] - z[1] * x[2] )   +   z[0] * ( x[1] * y[2] - y[1] * x[2] ) ;

            //DETERMINANT FOR THE DETRMINANT X
            double DX =q[0] * (y[1] * z[2] - z[1] * y[2] ) -  (y[0]) * ( q[1] * z[2] - z[1] * q[2] )   +   z[0] * (q[1] * y[2] - y[1] * q[2] );
            double ANSX = DX / D;
            Console.WriteLine("X= " + ANSX);

            //DETERMINANT FOR THE DETRMINANT Y
            double DY = x[0] * (q[1] * z[2] - z[1] * q[2] ) - q[0] * (x[1] * z[2] - z[1] * x[2]) + z[0]*(q[2] * x[1] - x[2] * q[1]);
            double ANSY = DY / D;
            Console.WriteLine("Y= " + ANSY);

            //DETERMINANT FOR THE DETRMINANT Z
            double DZ = x[0] * (y[1] * q[2] - q[1] * y[2]) - y[0]*(x[1] * q[2] - q[1] * x[2]) + q[0]*(x[1] * y[2] - y[1] * x[2] );
            double ANSZ = DZ / D;
            Console.WriteLine("Z= " + ANSZ);
      
           
            Console.ReadKey();
        }
    }
}