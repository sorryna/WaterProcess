using System;

namespace ProIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CalIndex();
        }

        public static void CalIndex(){
            var connectDB = new GetData();
            var getDataFromDB = connectDB.Get92Data();
            foreach (var item in getDataFromDB)
            {
                var count = 0;
                count++;
                var indexData = new ProcressIndex();
                var resultIndex = indexData.Propcress(item);
                connectDB.InsertIndexToDB(resultIndex);

                var pointData = new ProceassPoint();
                var resultPoint = pointData.Procress(resultIndex);
                connectDB.InsertPointToDB(resultPoint);
                System.Console.WriteLine(count);
            }
        }
    }
}
